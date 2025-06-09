namespace ProjOO
{
    public class Janela1
    {
        private Form myform;
        private Button mybutton;

        private Label mylabel;

        private TextBox mytextBox;

        public Janela1()
        {
            myform = new Form();
            mybutton = new Button();
            mylabel = new Label();
            mytextBox = new TextBox();
        }

        public void OpenWindow()
        {
            mybutton.Text = "Hello";
            mybutton.Location = new Point(10, 10);
            mylabel.Text = "Hello World";
            mylabel.Location = new Point(10, 100);

            mytextBox.Location = new Point(10, 50);

            mybutton.Click += (o, s) =>
            {
                mylabel.Text = mytextBox.Text;
            };
            
            myform.Controls.Add(mybutton);
            myform.Controls.Add(mytextBox);
            myform.Controls.Add(mylabel);
            myform.ShowDialog();

            while (myform.Created)
            {

            }
        }
    }
}
