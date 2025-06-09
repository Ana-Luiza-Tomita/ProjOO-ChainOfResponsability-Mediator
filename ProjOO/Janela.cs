namespace ProjOO
{
    public class Janela
    {
        private Form myform;
        private Button mybutton;

        public Label mylabel;

        private TextBox mytextBox;

        public Janela()
        {
            myform = new Form();
            mybutton = new Button();
            mylabel = new Label();
            mytextBox = new TextBox();
        }

        public void OpenWindow(Janela janela)
        {
            mybutton.Text = "Hello";
            mybutton.Location = new Point(10, 10);
            mylabel.Text = "Hello World";
            mylabel.Location = new Point(10, 100);

            mytextBox.Location = new Point(10, 50);

            mybutton.Click += (o, s) =>
            {
                janela.mylabel.Text = mytextBox.Text;
                this.myform.Close();
                janela.GetForm().ShowDialog();
            };

            myform.Controls.Add(mybutton);
            myform.Controls.Add(mytextBox);
            myform.Controls.Add(mylabel);
        }

        public Form GetForm()
        {
            return myform;
        }
    }
}
