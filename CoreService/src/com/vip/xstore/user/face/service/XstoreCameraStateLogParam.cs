using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.xstore.user.face.service{
	
	
	
	
	
	public class XstoreCameraStateLogParam {
		
		///<summary>
		/// 盒子mac地址
		///</summary>
		
		private string boxMacAddr_;
		
		///<summary>
		/// 盒子温度
		///</summary>
		
		private string boxTemperature_;
		
		///<summary>
		/// 盒子和外网延时
		///</summary>
		
		private string boxPing_;
		
		///<summary>
		/// 盒子程序版本号
		///</summary>
		
		private string boxSoftwareVersion_;
		
		///<summary>
		/// 盒子连接的摄像头运行日志列表
		///</summary>
		
		private List<com.vip.xstore.user.face.service.XstoreCameraStateLogModel> cameraStateLogs_;
		
		///<summary>
		/// 摄像头日志记录时间
		///</summary>
		
		private System.DateTime? stateLogTime_;
		
		public string GetBoxMacAddr(){
			return this.boxMacAddr_;
		}
		
		public void SetBoxMacAddr(string value){
			this.boxMacAddr_ = value;
		}
		public string GetBoxTemperature(){
			return this.boxTemperature_;
		}
		
		public void SetBoxTemperature(string value){
			this.boxTemperature_ = value;
		}
		public string GetBoxPing(){
			return this.boxPing_;
		}
		
		public void SetBoxPing(string value){
			this.boxPing_ = value;
		}
		public string GetBoxSoftwareVersion(){
			return this.boxSoftwareVersion_;
		}
		
		public void SetBoxSoftwareVersion(string value){
			this.boxSoftwareVersion_ = value;
		}
		public List<com.vip.xstore.user.face.service.XstoreCameraStateLogModel> GetCameraStateLogs(){
			return this.cameraStateLogs_;
		}
		
		public void SetCameraStateLogs(List<com.vip.xstore.user.face.service.XstoreCameraStateLogModel> value){
			this.cameraStateLogs_ = value;
		}
		public System.DateTime? GetStateLogTime(){
			return this.stateLogTime_;
		}
		
		public void SetStateLogTime(System.DateTime? value){
			this.stateLogTime_ = value;
		}
		
	}
	
}