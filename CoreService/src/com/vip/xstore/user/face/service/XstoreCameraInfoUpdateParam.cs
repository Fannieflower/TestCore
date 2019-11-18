using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.xstore.user.face.service{
	
	
	
	
	
	public class XstoreCameraInfoUpdateParam {
		
		///<summary>
		/// 自增长主键ID
		///</summary>
		
		private long? id_;
		
		///<summary>
		/// 门店pos机编码
		///</summary>
		
		private string posCode_;
		
		///<summary>
		/// 门店摄像头编码
		///</summary>
		
		private string cameraCode_;
		
		///<summary>
		/// 门店编码
		///</summary>
		
		private string storeCode_;
		
		///<summary>
		/// 腾讯云区域ID
		///</summary>
		
		private string txRegionCode_;
		
		///<summary>
		/// 腾讯云店铺ID
		///</summary>
		
		private string txStoreCode_;
		
		public long? GetId(){
			return this.id_;
		}
		
		public void SetId(long? value){
			this.id_ = value;
		}
		public string GetPosCode(){
			return this.posCode_;
		}
		
		public void SetPosCode(string value){
			this.posCode_ = value;
		}
		public string GetCameraCode(){
			return this.cameraCode_;
		}
		
		public void SetCameraCode(string value){
			this.cameraCode_ = value;
		}
		public string GetStoreCode(){
			return this.storeCode_;
		}
		
		public void SetStoreCode(string value){
			this.storeCode_ = value;
		}
		public string GetTxRegionCode(){
			return this.txRegionCode_;
		}
		
		public void SetTxRegionCode(string value){
			this.txRegionCode_ = value;
		}
		public string GetTxStoreCode(){
			return this.txStoreCode_;
		}
		
		public void SetTxStoreCode(string value){
			this.txStoreCode_ = value;
		}
		
	}
	
}