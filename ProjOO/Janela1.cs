namespace ProjOO
{
    public class Janela1
    {
        private Form myform;
        private Button mybutton;

        private Label mylabel;

        public Janela1()
        {
            myform = new Form();
            mybutton = new Button();
            mylabel = new Label();
        }

        public void OpenWindow()
        {
            mybutton.Text = "Hello";
            mybutton.Location = new System.Drawing.Point(10, 10);
            mybutton.Click += (o, s) =>
            {
                MessageBox.Show("world");
            };
            mylabel.Text = "";
            mylabel.Location = new System.Drawing.Point(20, 10);
            myform.Controls.Add(mybutton);
            myform.ShowDialog();

            while (myform.Created)
            {

            }
        }
    }
}
