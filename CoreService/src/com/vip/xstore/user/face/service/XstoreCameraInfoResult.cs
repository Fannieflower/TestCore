using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.xstore.user.face.service{
	
	
	
	
	
	public class XstoreCameraInfoResult {
		
		///<summary>
		/// code信息
		///</summary>
		
		private com.vip.xstore.user.face.service.common.CodeResult codeResult_;
		
		///<summary>
		/// 摄像头信息
		///</summary>
		
		private com.vip.xstore.user.face.service.XstoreCameraInfoModel xstoreCameraInfoModel_;
		
		public com.vip.xstore.user.face.service.common.CodeResult GetCodeResult(){
			return this.codeResult_;
		}
		
		public void SetCodeResult(com.vip.xstore.user.face.service.common.CodeResult value){
			this.codeResult_ = value;
		}
		public com.vip.xstore.user.face.service.XstoreCameraInfoModel GetXstoreCameraInfoModel(){
			return this.xstoreCameraInfoModel_;
		}
		
		public void SetXstoreCameraInfoModel(com.vip.xstore.user.face.service.XstoreCameraInfoModel value){
			this.xstoreCameraInfoModel_ = value;
		}
		
	}
	
}