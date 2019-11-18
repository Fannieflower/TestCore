using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.arplatform.merchModel.service{
	
	
	
	
	
	public class Jd3dModel {
		
		///<summary>
		/// pidVid
		///</summary>
		
		private string pidVid_;
		
		///<summary>
		/// 模型URL
		///</summary>
		
		private string modelUrl_;
		
		///<summary>
		/// barcode
		///</summary>
		
		private string barcode_;
		
		public string GetPidVid(){
			return this.pidVid_;
		}
		
		public void SetPidVid(string value){
			this.pidVid_ = value;
		}
		public string GetModelUrl(){
			return this.modelUrl_;
		}
		
		public void SetModelUrl(string value){
			this.modelUrl_ = value;
		}
		public string GetBarcode(){
			return this.barcode_;
		}
		
		public void SetBarcode(string value){
			this.barcode_ = value;
		}
		
	}
	
}