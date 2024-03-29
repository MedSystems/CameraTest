﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;

namespace WindowsFormsAppCamTest
{
	public partial class FormMain : Form
	{
		FilterInfoCollection filterInfoCollection;
		internal VideoCaptureDevice videoCaptureDevice;
		bool isRunning = true;
		VideoCapabilities[] res = new VideoCapabilities[0];

		public FormMain()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			listCamera();
			videoCaptureDevice = new VideoCaptureDevice();
			textBoxGenerate_TextChanged(null, null);
		}

		private void btnOpen_Click(object sender, EventArgs e)
		{
			if (videoCaptureDevice != null)
			{
				videoCaptureDevice.Stop();
				videoCaptureDevice.SignalToStop();
				videoCaptureDevice.NewFrame -= FinalFrame_NewFrame;
			}
			
			videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[cboCamera.SelectedIndex].MonikerString);

			videoCaptureDevice.NewFrame += FinalFrame_NewFrame;
			//videoCaptureDevice.Start();

			cboRresolution.Items.Clear();

			foreach (var res in videoCaptureDevice.VideoCapabilities)
			{
				cboRresolution.Items.Add(string.Format("{0}x{1} FPS={2}", res.FrameSize.Width, res.FrameSize.Height, res.MaximumFrameRate));
			}

			res = videoCaptureDevice.VideoCapabilities;
		}

		private void btnOpenUrl_Click(object sender, EventArgs e)
		{
			string url = textBoxUrl.Text;
			
			// load image from url and preview it in pictureBox
			var webClient = new System.Net.WebClient().OpenRead(url);
			if (webClient != null)
			{
				var image = Image.FromStream(webClient);
				LabelResolution.Text = $@"{image.Width}x{image.Height}";
				picCamera.Image = image;
			}
		}

		private void VideoCaptureDevice_VideoSourceError(object sender, VideoSourceErrorEventArgs eventArgs)
		{
			MessageBox.Show(eventArgs.Description, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		//c# webcam capture picture
		private void FinalFrame_NewFrame(object sender, NewFrameEventArgs eventArgs)
		{
			picCamera.Image = (Bitmap)eventArgs.Frame.Clone();
			picCamera.Invalidate();
			System.GC.Collect();

			if (!isRunning)
			{
				var dev = sender as VideoCaptureDevice;
				if (dev != null)
				{
					//dev.Stop();
					dev.SignalToStop();
				}

				System.Threading.Thread.CurrentThread.Abort();
			}
		}

		internal void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (videoCaptureDevice != null)
			{
				videoCaptureDevice.Stop();
				videoCaptureDevice.SignalToStop();
			}

			isRunning = false;
		}

		private void cboCamera_DropDown(object sender, EventArgs e)
		{
			//listCamera();
		}

		private void listCamera()
		{
			cboCamera.Items.Clear();

			filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
			foreach (FilterInfo Device in filterInfoCollection)
			{
				cboCamera.Items.Add(Device.Name);
			}

			if (cboCamera.Items.Count > 0)
			{
				cboCamera.SelectedIndex = 0;
			}
		}

		private void cboRresolution_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (videoCaptureDevice != null)
			{
				if (res.Length > 0)
				{
					videoCaptureDevice.VideoResolution = res[cboRresolution.SelectedIndex];

					videoCaptureDevice.SignalToStop();
					System.Threading.Thread.Sleep(500);
					videoCaptureDevice.Start();
				}
			}
		}

		private void radioButtonCameraURl_CheckedChanged(object sender, EventArgs e)
		{
			if (radioButtonCamera.Checked)
			{
				groupBoxCamera.Enabled = true;
				groupBoxUrl.Enabled = false;
			}
			else
			{
				groupBoxCamera.Enabled = false;
				groupBoxUrl.Enabled = true;
			}
		}

		private void textBoxGenerate_TextChanged(object sender, EventArgs e)
		{
			var auth = Convert.ToBase64String(Encoding.UTF8.GetBytes(textBoxUsername.Text + ':' + textBoxPassword.Text));
			var url = "http://" + textBoxIp.Text + ":" + textBoxPort.Text + "/snapshot.jpg?size=-1x-1&download=yes&auth=" + auth;
			
			textBoxUrl.Text = url;
		}
	}
}
