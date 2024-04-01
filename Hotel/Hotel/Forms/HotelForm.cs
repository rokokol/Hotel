using Hotel.Classes;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.Devices;
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
            LoadDB();
            dataGrid.DataSource = MakeGridContent([1, 2, 3, 4]);
            //DBTest();
            logger.Info("All components are initialized");
        }

        private IdNamePair[] MakeGridContent(int[] allowed)
        {
            var sourse =
                db.Persons.Where(s =>
                allowed.Contains(s.StatusId) &&
                s.Name.Contains(searchBox.Text) // Я пытался сделать через ToLower, но у меня ничего не получается, он не реагирует на первую букву
                ).ToArray();
            var grid = new List<IdNamePair>();
            for (var i = 0; i < sourse.Count(); i++)
            {
                grid.Add(new IdNamePair(sourse[i]));
            }

            return grid.ToArray();
        }

        private void LoadDB()
        {
            db.Database.EnsureCreated();
            db.Persons.Load();
            db.Statuses.Load();
            logger.Trace("Database Person and Statuses loaded, Database ensured");
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
                new DateTime(2022, 2, 1));
            persons[1] = new Person(2,
                1,
                "Диана",
                new DateTime(2021, 4, 8),
                new DateTime(2022, 10, 7));
            persons[2] = new Person(3,
                2,
                "Марат",
                new DateTime(2023, 2, 1),
                new DateTime(2024, 2, 1));
            persons[3] = new Person(4,
                3,
                "Борис",
                new DateTime(2021, 2, 1),
                new DateTime(2021, 2, 4));
            persons[4] = new Person(5,
                4,
                "Лиза",
                new DateTime(2022, 2, 1),
                DateTime.Now);

            foreach (var stat in statuses)
                db.Statuses.Add(stat);

            foreach (var person in persons)
                db.Persons.Add(person);
            db.SaveChanges();
            logger.Trace("Test DB are loaded");
        }

        private void resCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            dataGrid.DataSource = MakeGridContent(GetChecked());
            logger.Trace($"resCheckBox checked to {resCheckBox.Checked} where '{searchBox.Text}'");
        }

        private void freeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            dataGrid.DataSource = MakeGridContent(GetChecked());
            logger.Trace($"freeCheckBox checked to {freeCheckBox.Checked} where '{searchBox.Text}'");
        }

        private void bookCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            dataGrid.DataSource = MakeGridContent(GetChecked());
            logger.Trace($"bookCheckBox checked to {bookCheckBox.Checked} where '{searchBox.Text}'");
        }

        private void outCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            dataGrid.DataSource = MakeGridContent(GetChecked());
            logger.Trace($"outCheckBox checked to {outCheckBox.Checked} where '{searchBox.Text}'");
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            dataGrid.DataSource = MakeGridContent(GetChecked());
            logger.Info($"Search '{searchBox.Text}'");
        }

        private void dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var user = db.Persons.Find((int)dataGrid.Rows[e.RowIndex].Cells[0].Value);
            userGrid.DataSource =
                new Person[] { user };
            logger.Info($"Selected user #{user.Id}");
        }
    }
}
