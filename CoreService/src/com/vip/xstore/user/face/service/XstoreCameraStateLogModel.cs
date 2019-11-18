using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.xstore.user.face.service{
	
	
	
	
	
	public class XstoreCameraStateLogModel {
		
		///<summary>
		/// 门店摄像头编码
		///</summary>
		
		private string cameraCode_;
		
		///<summary>
		/// 摄像头工作状态状态码
		///</summary>
		
		private string cameraStateCode_;
		
		///<summary>
		/// 设备和摄像头延时
		///</summary>
		
		private string cameraPing_;
		
		///<summary>
		/// 摄像头工作状态信息描述
		///</summary>
		
		private string cameraStateMsg_;
		
		///<summary>
		/// 摄像头视频流格式
		///</summary>
		
		private string cameraFormat_;
		
		///<summary>
		/// 摄像头fps
		///</summary>
		
		private string cameraFps_;
		
		///<summary>
		/// 摄像头分辨率
		///</summary>
		
		private string cameraResolution_;
		
		public string GetCameraCode(){
			return this.cameraCode_;
		}
		
		public void SetCameraCode(string value){
			this.cameraCode_ = value;
		}
		public string GetCameraStateCode(){
			return this.cameraStateCode_;
		}
		
		public void SetCameraStateCode(string value){
			this.cameraStateCode_ = value;
		}
		public string GetCameraPing(){
			return this.cameraPing_;
		}
		
		public void SetCameraPing(string value){
			this.cameraPing_ = value;
		}
		public string GetCameraStateMsg(){
			return this.cameraStateMsg_;
		}
		
		public void SetCameraStateMsg(string value){
			this.cameraStateMsg_ = value;
		}
		public string GetCameraFormat(){
			return this.cameraFormat_;
		}
		
		public void SetCameraFormat(string value){
			this.cameraFormat_ = value;
		}
		public string GetCameraFps(){
			return this.cameraFps_;
		}
		
		public void SetCameraFps(string value){
			this.cameraFps_ = value;
		}
		public string GetCameraResolution(){
			return this.cameraResolution_;
		}
		
		public void SetCameraResolution(string value){
			this.cameraResolution_ = value;
		}
		
	}
	
}