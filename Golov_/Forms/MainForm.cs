using Golov_.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Golov_
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        //Список картинок капчи. Хранит порядок отображения изображений.
        private List<int> list = new List<int>() {3, 4, 1, 2};

        //Модель Entity Framework для работы с базой данных
        private ModelEF modelEF = new ModelEF();

        //Авторизованный пользователб (Заполняется после успешного входа)
        private Users users;

        private void EnterButton_Click(object sender, EventArgs e)
        {
            users = modelEF.Users.FirstOrDefault(
                x => x.login == TextBoxLogin.Text 
                && x.password == TextBoxPassword.Text);
            if (users != null)
            {
                if (users.Status == "Active")
                {
                    panelCaptch.Visible = true;
                }
                else
                {
                    MessageBox.Show("Вы заблокированы! Обратитесь к библиотекарю");
                }
                return;
            }
            else
            {
                users = modelEF.Users.FirstOrDefault(
                x => x.login == TextBoxLogin.Text);
                if (users != null) 
                {
                    if (users.Status == "Blocked")
                    {
                        MessageBox.Show("Вы заблокированы! Обратитесь к библиотекарю");
                    }
                    users.BadLoginTry += 1;
                    modelEF.SaveChanges();
                    MessageBox.Show($"Вы не правильно ввели пароль. У вас осталось попыток {3 - users.BadLoginTry}");
                    if (users.BadLoginTry == 3 || users.BadLoginTry > 3)
                    {
                        users.Status = "Blocked";
                        modelEF.SaveChanges();
                        MessageBox.Show("Вы заблокированы! Обратитесь к библиотекарю");
                    }
                }
                else 
                {
                    MessageBox.Show($"Вы не правильно ввели логин или пароль. Пожалуйста проверьте еще раз введеные данные");
                }
            }
        }
        private void LoadPictures() 
        {
            pictureBoxCaptch1.Image = Image.FromFile($@"Pictures\{1}.png");
            pictureBoxCaptch2.Image = Image.FromFile($@"Pictures\{2}.png");
            pictureBoxCaptch3.Image = Image.FromFile($@"Pictures\{3}.png");
            pictureBoxCaptch4.Image = Image.FromFile($@"Pictures\{4}.png");

        }
        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void NextButton_Click(object sender, EventArgs e)
        {

        }

        private void ReadyButton_Click(object sender, EventArgs e)
        {

        }
    }
}
