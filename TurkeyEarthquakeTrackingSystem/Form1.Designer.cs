
namespace TurkeyEarthquakeTrackingSystem
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.EarthquakeMap = new GMap.NET.WindowsForms.GMapControl();
            this.SuspendLayout();
            // 
            // EarthquakeMap
            // 
            this.EarthquakeMap.AllowDrop = true;
            this.EarthquakeMap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EarthquakeMap.Bearing = 0F;
            this.EarthquakeMap.CanDragMap = true;
            this.EarthquakeMap.EmptyTileColor = System.Drawing.Color.Navy;
            this.EarthquakeMap.GrayScaleMode = false;
            this.EarthquakeMap.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.EarthquakeMap.LevelsKeepInMemory = 5;
            this.EarthquakeMap.Location = new System.Drawing.Point(1, 0);
            this.EarthquakeMap.MarkersEnabled = true;
            this.EarthquakeMap.MaxZoom = 24;
            this.EarthquakeMap.MinZoom = 0;
            this.EarthquakeMap.MouseWheelZoomEnabled = true;
            this.EarthquakeMap.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionWithoutCenter;
            this.EarthquakeMap.Name = "EarthquakeMap";
            this.EarthquakeMap.NegativeMode = false;
            this.EarthquakeMap.PolygonsEnabled = true;
            this.EarthquakeMap.RetryLoadTile = 0;
            this.EarthquakeMap.RoutesEnabled = true;
            this.EarthquakeMap.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.EarthquakeMap.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.EarthquakeMap.ShowTileGridLines = false;
            this.EarthquakeMap.Size = new System.Drawing.Size(969, 717);
            this.EarthquakeMap.TabIndex = 0;
            this.EarthquakeMap.Zoom = 6D;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1338, 716);
            this.Controls.Add(this.EarthquakeMap);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl EarthquakeMap;
    }
}

