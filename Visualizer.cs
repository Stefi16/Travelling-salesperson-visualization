using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace courseProjectTSP
{
    public partial class Visualizer : Form
    {
        private const int expanderX = 160;
        private const int expanderY = 200;
        private  int startPointX = 0;
        private int startPointY = 10;
        private static int endPointX = 150;
        private static int endPointY = 200;
        private List<Circle> circles = new List<Circle>();
        private List<Circle> circlesRoute = new List<Circle>();
        private List<Line> lines = new List<Line>();
        private List<Line> linesRoute = new List<Line>();
        private List<int> resultTour = new List<int>();
        Random randomizer = new Random();
        private int lineRedCounter = 0;
        private int result = 0;

        public Visualizer()
        {
            InitializeComponent();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            foreach (var circle in circles)
            {
                circle.Paint(e.Graphics);
            }
            foreach (var line in lines)
            {
                line.Paint(e.Graphics);
            }

        }
        private void Home_Load(object sender, EventArgs e)
        {
            if(GlobalVariables.generateRandom)
            {
                GenerateRandom();
            } else
            {
                var tsm = new TsmAlgorithm(GlobalVariables.adjecencyMatrix);
                this.resultTour = tsm.getTour();
                this.result = tsm.getCost();
            }
            this.SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint
            | ControlStyles.OptimizedDoubleBuffer, true);

            CircleInitializer();
            LineInitializer();

            using (Graphics graphics = CreateGraphics())
            {
                foreach (var circle in circles)
                {
                    circle.Paint(graphics);
                }
                foreach (var line in lines)
                {
                    line.Paint(graphics);
                }
            }


            Invalidate();
            Application.DoEvents();
            writeResult.Text = $"{this.result}";
            Route();
        }
        private void GenerateRandom()
        {
         int a = randomizer.Next(0, 30); 
         int n = randomizer.Next(5, 7);
         GlobalVariables.adjecencyMatrix = new int[n, n];
            if (a <= 15)
            {
                for (int i = 0; i < GlobalVariables.adjecencyMatrix.GetLength(0); i++)
                {
                    for (int j = 0; j < GlobalVariables.adjecencyMatrix.GetLength(0); j++)
                    {
                            GlobalVariables.adjecencyMatrix[i, j] = randomizer.Next(7, 50);
                    }
                }
            }
            else
            {
                for (int i = 0; i < GlobalVariables.adjecencyMatrix.GetLength(0); i++)
                {
                    for (int j = 0; j < GlobalVariables.adjecencyMatrix.GetLength(0); j++)
                    {
                        if (GlobalVariables.adjecencyMatrix[i,j] == 0)
                        {
                            GlobalVariables.adjecencyMatrix[i, j] = randomizer.Next(7, 50);
                            GlobalVariables.adjecencyMatrix[j, i] = GlobalVariables.adjecencyMatrix[i, j];
                        }
                            
                    }
                }
            }
           var results = new TsmAlgorithm(GlobalVariables.adjecencyMatrix);
           this.resultTour = results.getTour();
           this.result = results.getCost();
            GlobalVariables.generateRandom = false;
        }
        private void CircleInitializer()
        {
            for (int i = 0; i < GlobalVariables.adjecencyMatrix.GetLength(0); i++)
            {
                if (i == 0 || i % 2 == 0)
                {
                    var startRandomX = randomizer.Next(startPointX, endPointX);
                    var startRandomY = randomizer.Next(startPointY, endPointY);

                    circles.Add(new Circle(new Point(startRandomX, startRandomY), i));

                    startPointX += expanderX;
                    startPointY += expanderY + 10;

                    endPointX += expanderX;
                    endPointY += expanderY;
                }
                else
                {
                    var startRandomX = randomizer.Next(startPointX, endPointX);
                    var startRandomY = randomizer.Next(startPointY, endPointY);

                    circles.Add(new Circle(new Point(startRandomX, startRandomY), i));

                    startPointX += expanderX;
                    startPointY -= expanderY + 5;

                    endPointX += expanderX;
                    endPointY -= expanderY + 5;
                }

            }
            startPointX = 0;
            startPointY = 10;
            endPointX = 150;
            endPointY = 200;
        }
        private void LineInitializer()
        {

            for (int i = 0; i < GlobalVariables.adjecencyMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < GlobalVariables.adjecencyMatrix.GetLength(1); j++)
                {
                    if (i < j)
                    {
                        lines.Add(new Line(circles.ElementAt(i).Center, circles.ElementAt(j).Center));
                        if (GlobalVariables.adjecencyMatrix[i, j] == GlobalVariables.adjecencyMatrix[j, i])
                        {
                            cost.Items.Add($"[{i},{j} = {j},{i}] = {GlobalVariables.adjecencyMatrix[i, j]}");
                        }
                        else 
                        {
                            cost.Items.Add($"[{i},{j}] = {GlobalVariables.adjecencyMatrix[i, j]}");
                            cost.Items.Add($"[{j},{i}] = {GlobalVariables.adjecencyMatrix[j, i]}");
                        }
                    }
                }
            }
        }
        private void Route()
        {
            for (int i = 0; i < resultTour.Count(); i++)
            {
                foreach (var circle in circles)
                {
                    if (resultTour.ElementAt(i) == circle.nodeNum)
                        this.circlesRoute.Add(circle);
                }
            }

            for (int i = 0; i < circlesRoute.Count() - 1; i++)
            {
                optimalRoute.Items.Add($"[{circlesRoute.ElementAt(i).nodeNum}, {circlesRoute.ElementAt(i + 1).nodeNum}] = " +
                    $"{GlobalVariables.adjecencyMatrix[circlesRoute.ElementAt(i).nodeNum, circlesRoute.ElementAt(i + 1).nodeNum]}");
                foreach (var line in lines)
                {
                    if (line.Contains(circlesRoute.ElementAt(i).Center) &&
                        line.Contains(circlesRoute.ElementAt(i + 1).Center))
                        this.linesRoute.Add(line);
                }
            }
            Invalidate();
            Application.DoEvents();
        }

        private void next_Click(object sender, EventArgs e)
        {
            if(this.lineRedCounter < this.linesRoute.Count())
            {
                this.linesRoute.ElementAt(lineRedCounter).MyColor = Color.Red;
                Invalidate();
                Application.DoEvents();
                lineRedCounter++;

                if(this.lineRedCounter == this.linesRoute.Count())
                    this.Controls.Remove(next);
            }
        }

    }
}
