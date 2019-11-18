using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.xstore.user.face.service{
	
	
	
	
	
	public class XstoreCameraStateLogReqParam {
		
		///<summary>
		/// 摄像头所在门店编码
		///</summary>
		
		private string storeCode_;
		
		///<summary>
		/// 摄像头编码
		///</summary>
		
		private string cameraCode_;
		
		///<summary>
		/// 查询起始时间
		///</summary>
		
		private System.DateTime? startTime_;
		
		///<summary>
		/// 查询起始时间
		///</summary>
		
		private System.DateTime? endTime_;
		
		///<summary>
		/// 运行状态(正常/异常/全部，默认全部)
		///</summary>
		
		private com.vip.xstore.user.face.service.CameraState? runState_;
		
		///<summary>
		/// 分页信息
		///</summary>
		
		private com.vip.xstore.user.face.service.common.PageInfo pageInfo_;
		
		public string GetStoreCode(){
			return this.storeCode_;
		}
		
		public void SetStoreCode(string value){
			this.storeCode_ = value;
		}
		public string GetCameraCode(){
			return this.cameraCode_;
		}
		
		public void SetCameraCode(string value){
			this.cameraCode_ = value;
		}
		public System.DateTime? GetStartTime(){
			return this.startTime_;
		}
		
		public void SetStartTime(System.DateTime? value){
			this.startTime_ = value;
		}
		public System.DateTime? GetEndTime(){
			return this.endTime_;
		}
		
		public void SetEndTime(System.DateTime? value){
			this.endTime_ = value;
		}
		public com.vip.xstore.user.face.service.CameraState? GetRunState(){
			return this.runState_;
		}
		
		public void SetRunState(com.vip.xstore.user.face.service.CameraState? value){
			this.runState_ = value;
		}
		public com.vip.xstore.user.face.service.common.PageInfo GetPageInfo(){
			return this.pageInfo_;
		}
		
		public void SetPageInfo(com.vip.xstore.user.face.service.common.PageInfo value){
			this.pageInfo_ = value;
		}
		
	}
	
}