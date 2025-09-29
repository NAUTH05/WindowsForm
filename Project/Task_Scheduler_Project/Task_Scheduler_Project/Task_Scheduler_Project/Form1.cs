using MongoDB.Driver;
using MongoDB.Bson;


namespace Task_Scheduler_Project
{
    public partial class Form1 : Form
    {
        const string connectionUri = "mongodb+srv://admin:123123aA@cluster1.twylial.mongodb.net/?retryWrites=true&w=majority&appName=Cluster1";
        private MongoClient client;
        private IMongoDatabase database;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
