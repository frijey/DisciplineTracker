using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Threading;

namespace Discipline_Tracker
{
    public class Notify : Button
    {
        //Variables globales del control
        public int moveSpeed = 10;
        public int delay = 25;
        public Form formPadrePersistent = null;

        public Notify(Form formPadre, string Msg, int widthSize = 200)
        {
            this.Text = Msg;
            this.ForeColor = Color.Black;
            this.BackColor = Color.FromArgb(136, 241, 115);
            this.Font = new Font("Calibri", 10f);
            this.FlatAppearance.BorderSize = 0;
            this.FlatStyle = FlatStyle.Flat;
            this.TabStop = false;
            this.Size = new Size(widthSize, 25);
            this.Location = new Point(formPadre.Width, 40);
            this.ImageAlign = ContentAlignment.MiddleLeft;
            this.TextAlign = ContentAlignment.MiddleCenter;
            formPadrePersistent = formPadre;
            PreAppear();
        }

        protected override void OnClick(EventArgs e)
        {
            PreDissappear();
        }

        //public void PreAppear()
        //{
        //    Thread myNotAppear = new Thread(() => Appear());
        //    myNotAppear.Start();
        //}

        //public void Appear()
        //{
        //    try
        //    {
        //        formPadrePersistent.Invoke((MethodInvoker)delegate ()
        //        {
        //            this.BringToFront();
        //        });

        //        while (this.Location.X > formPadrePersistent.Size.Width - 10 - this.Size.Width)
        //        {
        //            formPadrePersistent.Invoke((MethodInvoker)delegate ()
        //            {
        //                this.Location = new Point(this.Location.X - moveSpeed, this.Location.Y);
        //                Thread.Sleep(delay);
        //            });
        //        }

        //        PreDissappear();

        //    }
        //    catch { }
        //}

        public async void PreAppear()
        {
            await Appear();
        }

        public async Task<bool> Appear()
        {
            try
            {
                formPadrePersistent.Invoke((MethodInvoker)delegate ()
                {
                    this.BringToFront();
                });

                formPadrePersistent.Invoke((MethodInvoker)async delegate ()
                {
                    this.Location = new Point(formPadrePersistent.Size.Width - 10 - this.Size.Width, this.Location.Y);
                    await Task.Delay(delay);
                });

                PreDissappear();

            }
            catch { }

            return true;
        }

        public void PreDissappear()
        {
            Thread myNotifyDisapearing = new Thread(() => Disappear());
            myNotifyDisapearing.Start();
        }

        public void Disappear()
        {
            try
            {
                Thread.Sleep(3000);

                while (this.Location.X < formPadrePersistent.Width)
                {
                    formPadrePersistent.Invoke((MethodInvoker)delegate ()
                    {
                        this.Location = new Point(this.Location.X + moveSpeed, this.Location.Y);
                        Thread.Sleep(delay);
                    });
                }

            }
            catch { }
        }

        protected override void OnGotFocus(EventArgs e)
        {
        }

    }
}
