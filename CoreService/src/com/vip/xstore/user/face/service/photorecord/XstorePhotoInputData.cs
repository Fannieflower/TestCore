using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.xstore.user.face.service.photorecord{
	
	
	
	
	
	public class XstorePhotoInputData {
		
		///<summary>
		/// 照片文件名
		///</summary>
		
		private string photoName_;
		
		///<summary>
		/// 图片内容Base64数据
		///</summary>
		
		private string photoBase64Data_;
		
		public string GetPhotoName(){
			return this.photoName_;
		}
		
		public void SetPhotoName(string value){
			this.photoName_ = value;
		}
		public string GetPhotoBase64Data(){
			return this.photoBase64Data_;
		}
		
		public void SetPhotoBase64Data(string value){
			this.photoBase64Data_ = value;
		}
		
	}
	
}