using latihanCustomListFlyoutPanel.model;
using System.IO;
using System.Windows.Forms;
using System.Linq;
using Newtonsoft.Json;

namespace latihanCustomListFlyoutPanel
{
    public partial class Form1 : Form
    {
        public List<Movie> listMovie;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listMovie = new List<Movie>();
            var json = Resources.movie; //read the data from json file
            listMovie = JsonConvert.DeserializeObject<List<Movie>>(json);  //insert it into list


            var listMoviesItems = new CustomListItem[30];
            flowLayoutContainer.Controls.Clear();
            int index = 0;
            //var pic = new PictureBox()
            foreach (var movieItem in listMovie.Take(30))
            {
                {
                    listMoviesItems[index] = new CustomListItem();

                    listMoviesItems[index].Title = movieItem.title;
                    listMoviesItems[index].Overview = movieItem.overview;
                    listMoviesItems[index].releaseDate = movieItem.release_date;

                    var url = "https://image.tmdb.org/t/p/w200" + movieItem.poster_path;
                    listMoviesItems[index].URL = url ;

                    flowLayoutContainer.Controls.Add(listMoviesItems[index]);
                    index++;
                }

            }
        }
    }
}