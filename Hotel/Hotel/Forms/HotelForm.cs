using Hotel.Classes;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;
using NLog;
using NLog.Config;

namespace Hotel
{
    public partial class HotelForm : Form
    {
        #region Vars

        private DatabaseContext db = new DatabaseContext();
        private static Logger logger = LogManager.GetCurrentClassLogger();

        #endregion

        public HotelForm()
        {
            LogManager.Configuration = new XmlLoggingConfiguration("../../../Source/NLog.config");
            InitializeComponent();
            //db.Database.EnsureDeleted();
            LoadDB();
            dataGrid.DataSource = MakeGridContent([1, 2, 3, 4]);
            //DBTest();
            logger.Info("All components are initialized");
        }

        public IdNamePair[] MakeGridContent(int[] allowed)
        {
            var sourсe =
                db.Persons.Where(s =>
                allowed.Contains(s.StatusId) &&
                s.Name.Contains(searchBox.Text) // Я пытался сделать через ToLower, но у меня ничего не получается, он не реагирует на первую букву
                ).ToArray();
            var grid = new List<IdNamePair>();
            for (var i = 0; i < sourсe.Count(); i++)
            {
                grid.Add(new IdNamePair(sourсe[i]));
            }

            return grid.ToArray();
        }

        private void LoadDB()
        {
            try
            {
                db.Database.EnsureCreated();
                db.Persons.Load();
                db.Statuses.Load();
                logger.Trace("Database Person and Statuses loaded, Database ensured");
            }
            catch (SqliteException ex)
            {
                logger.Fatal($"Sqlite exception | {ex.StackTrace}");
                MessageBox.Show("Database not found",
                    "Sqlite exception",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                logger.Fatal($"{ex.Data} | {ex.StackTrace}");
                MessageBox.Show(ex.StackTrace,
                    ex.Data.ToString(),
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private int[] GetChecked()
        {
            var allowed = new List<int>();
            if (resCheckBox.Checked)
            {
                allowed.Add(1);
            }
            if (freeCheckBox.Checked)
            {
                allowed.Add(2);
            }
            if (bookCheckBox.Checked)
            {
                allowed.Add(3);
            }
            if (outCheckBox.Checked)
            {
                allowed.Add(4);
            }

            if (allowed.Count == 0)
            {
                return [1, 2, 3, 4];
            }

            return allowed.ToArray();
        }

        private void DBTest()
        {
            var statuses = new Status[4];
            statuses[0] = new Status(1, "Зарезервировано");
            statuses[1] = new Status(2, "Свободные");
            statuses[2] = new Status(3, "Заняты");
            statuses[3] = new Status(4, "Выписываются");

            var persons = new Person[5];
            persons[0] = new Person(1,
                1,
                "Илья",
                new DateTime(2021, 2, 1),
                new DateTime(2022, 2, 1),
                Person.PictureToByteArr(Image.FromFile("../../../Source/cat5.jpg")));
            persons[1] = new Person(2,
                1,
                "Диана",
                new DateTime(2021, 4, 8),
                new DateTime(2022, 10, 7),
                Person.PictureToByteArr(Image.FromFile("../../../Source/cat1.jpg")));
            persons[2] = new Person(3,
                2,
                "Марат",
                new DateTime(2026, 2, 1),
                new DateTime(2025, 2, 1),
                Person.PictureToByteArr(Image.FromFile("../../../Source/cat2.jpg")));
            persons[3] = new Person(4,
                3,
                "Борис",
                new DateTime(2021, 2, 1),
                new DateTime(2021, 2, 4),
                Person.PictureToByteArr(Image.FromFile("../../../Source/cat3.jpg")));
            persons[4] = new Person(5,
                4,
                "Лиза",
                new DateTime(2022, 2, 1),
                DateTime.Now,
                Person.PictureToByteArr(Image.FromFile("../../../Source/cat4.jpg")));

            foreach (var stat in statuses)
                db.Statuses.Add(stat);

            foreach (var person in persons)
                db.Persons.Add(person);
            db.SaveChanges();
            logger.Trace($"Test DB are loaded || {persons.Length} users | {statuses.Length} statuses");
        }

        private void resCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            dataGrid.DataSource = MakeGridContent(GetChecked());
            logger.Debug($"resCheckBox checked to {resCheckBox.Checked} where '{searchBox.Text}'");
        }

        private void freeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            dataGrid.DataSource = MakeGridContent(GetChecked());
            logger.Debug($"freeCheckBox checked to {freeCheckBox.Checked} where '{searchBox.Text}'");
        }

        private void bookCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            dataGrid.DataSource = MakeGridContent(GetChecked());
            logger.Debug($"bookCheckBox checked to {bookCheckBox.Checked} where '{searchBox.Text}'");
        }

        private void outCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            dataGrid.DataSource = MakeGridContent(GetChecked());
            logger.Debug($"outCheckBox checked to {outCheckBox.Checked} where '{searchBox.Text}'");
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            dataGrid.DataSource = MakeGridContent(GetChecked());
            logger.Info($"Search '{searchBox.Text}'");
        }

        private void dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var user = db.Persons.Find((int)dataGrid.Rows[e.RowIndex].Cells[0].Value);

            var status = db.Statuses.Find(user.StatusId).StatusName;
            statusValueLabel.Text = status;

            var name = user.Name;
            nameLabel.Text = name;

            var incomeDateString = $"{user.IncomeTime.Day}.{user.IncomeTime.Month}.{user.IncomeTime.Year}";
            incomeDate.Text = incomeDateString;
            if (DateTime.Now < user.IncomeTime)
            {
                logger.Warn($"Income date is later than current time");
            }

            var outcomeDateString = $"{user.OutcomeTime.Day}.{user.OutcomeTime.Month}.{user.OutcomeTime.Year}";
            outcomeDate.Text = outcomeDateString;
            if (user.OutcomeTime < user.IncomeTime)
            {
                logger.Warn($"Income date is later than outcome date");
            }

            var number = user.Id;
            numberLabel.Text = $"Номер № {number}";
            if (number < 0)
            {
                logger.Warn($"Negative number");
            }

            Image image = Image.FromFile("../../../Source/catDefault.png");
            try
            {
                image = Person.ByteArrToPicture(user.Picture);
                imageBox.Image = image;
            }
            catch (BadImageFormatException)
            {
                logger.Error($"Bad image format | id - {user.Id}");
                MessageBox.Show("Bad image format",
                    "Image exception",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                logger.Error($"{ex.Data} | {ex.StackTrace}");
                MessageBox.Show(ex.StackTrace,
                    ex.Data.ToString(),
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

            logger.Trace($"Loaded status {status} |" +
                $" Loaded name {name} |" +
                $" Loaded income date {incomeDateString} |" +
                $" Loaded outcome date {outcomeDateString} |" +
                $" Loaded number {number} |" +
                $" Image loaded with size {image.Size.Height}x{image.Size.Width}");
            logger.Info($"Selected user #{user.Id}");
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            var now = DateTime.Now;
            timeLabel.Text = $"{now.Hour} : {now.Minute} : {now.Second}";
        }
    }
}
