using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.xstore.user.face.service{
	
	
	
	
	
	public class XstoreCameraBatchDelParam {
		
		///<summary>
		/// 店铺Id
		///</summary>
		
		private List<long?> cameraIdList_;
		
		public List<long?> GetCameraIdList(){
			return this.cameraIdList_;
		}
		
		public void SetCameraIdList(List<long?> value){
			this.cameraIdList_ = value;
		}
		
	}
	
}