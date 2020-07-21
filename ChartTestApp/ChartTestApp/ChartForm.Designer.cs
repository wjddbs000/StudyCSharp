﻿namespace ChartTestApp
{
    partial class ChartForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.BtnYValues = new MetroFramework.Controls.MetroButton();
            this.BtnXYValues = new MetroFramework.Controls.MetroButton();
            this.BtnDataBind = new MetroFramework.Controls.MetroButton();
            this.BtnMultiChart = new MetroFramework.Controls.MetroButton();
            this.BtnDBBind = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(11, 94);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Score";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(513, 319);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.BtnDBBind);
            this.metroPanel1.Controls.Add(this.BtnMultiChart);
            this.metroPanel1.Controls.Add(this.BtnDataBind);
            this.metroPanel1.Controls.Add(this.BtnXYValues);
            this.metroPanel1.Controls.Add(this.BtnYValues);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(530, 94);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(169, 319);
            this.metroPanel1.TabIndex = 1;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // BtnYValues
            // 
            this.BtnYValues.Location = new System.Drawing.Point(27, 23);
            this.BtnYValues.Name = "BtnYValues";
            this.BtnYValues.Size = new System.Drawing.Size(143, 34);
            this.BtnYValues.TabIndex = 2;
            this.BtnYValues.Text = "Only Y Values";
            this.BtnYValues.UseSelectable = true;
            this.BtnYValues.Click += new System.EventHandler(this.BtnYValues_Click);
            // 
            // BtnXYValues
            // 
            this.BtnXYValues.Location = new System.Drawing.Point(27, 63);
            this.BtnXYValues.Name = "BtnXYValues";
            this.BtnXYValues.Size = new System.Drawing.Size(143, 34);
            this.BtnXYValues.TabIndex = 2;
            this.BtnXYValues.Text = "XY Values";
            this.BtnXYValues.UseSelectable = true;
            this.BtnXYValues.Click += new System.EventHandler(this.BtnXYValues_Click);
            // 
            // BtnDataBind
            // 
            this.BtnDataBind.Location = new System.Drawing.Point(26, 103);
            this.BtnDataBind.Name = "BtnDataBind";
            this.BtnDataBind.Size = new System.Drawing.Size(143, 34);
            this.BtnDataBind.TabIndex = 2;
            this.BtnDataBind.Text = "Data Bind";
            this.BtnDataBind.UseSelectable = true;
            this.BtnDataBind.Click += new System.EventHandler(this.BtnDataBind_Click);
            // 
            // BtnMultiChart
            // 
            this.BtnMultiChart.Location = new System.Drawing.Point(27, 143);
            this.BtnMultiChart.Name = "BtnMultiChart";
            this.BtnMultiChart.Size = new System.Drawing.Size(143, 34);
            this.BtnMultiChart.TabIndex = 2;
            this.BtnMultiChart.Text = "MultiChart";
            this.BtnMultiChart.UseSelectable = true;
            this.BtnMultiChart.Click += new System.EventHandler(this.BtnMultiChart_Click);
            // 
            // BtnDBBind
            // 
            this.BtnDBBind.Location = new System.Drawing.Point(23, 183);
            this.BtnDBBind.Name = "BtnDBBind";
            this.BtnDBBind.Size = new System.Drawing.Size(143, 34);
            this.BtnDBBind.TabIndex = 2;
            this.BtnDBBind.Text = "DB Bind";
            this.BtnDBBind.UseSelectable = true;
            this.BtnDBBind.Click += new System.EventHandler(this.BtnDBBind_Click);
            // 
            // ChartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 460);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.chart1);
            this.MinimizeBox = false;
            this.Name = "ChartForm";
            this.Resizable = false;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.metroPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroButton BtnXYValues;
        private MetroFramework.Controls.MetroButton BtnYValues;
        private MetroFramework.Controls.MetroButton BtnDataBind;
        private MetroFramework.Controls.MetroButton BtnMultiChart;
        private MetroFramework.Controls.MetroButton BtnDBBind;
    }
}

