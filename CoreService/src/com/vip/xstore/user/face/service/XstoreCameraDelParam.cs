using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.xstore.user.face.service{
	
	
	
	
	
	public class XstoreCameraDelParam {
		
		///<summary>
		/// 店铺code
		///</summary>
		
		private string storeCode_;
		
		///<summary>
		/// 摄像头code
		///</summary>
		
		private string cameraCode_;
		
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
		
	}
	
}