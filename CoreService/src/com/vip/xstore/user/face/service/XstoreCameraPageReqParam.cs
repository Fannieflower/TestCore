using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.xstore.user.face.service{
	
	
	
	
	
	public class XstoreCameraPageReqParam {
		
		///<summary>
		/// 摄像头编号
		///</summary>
		
		private string cameraCode_;
		
		///<summary>
		/// 门店编码
		///</summary>
		
		private string storeCode_;
		
		///<summary>
		/// 分页信息
		///</summary>
		
		private com.vip.xstore.user.face.service.common.PageInfo pageInfo_;
		
		///<summary>
		/// POS机编码
		///</summary>
		
		private string posCode_;
		
		///<summary>
		/// 外部店铺码
		///</summary>
		
		private string dzStoreCode_;
		
		///<summary>
		/// 区域码
		///</summary>
		
		private string regionCode_;
		
		///<summary>
		/// 城市码
		///</summary>
		
		private string cityCode_;
		
		///<summary>
		/// 省份码
		///</summary>
		
		private string provinceCode_;
		
		///<summary>
		/// 是否删除 0-未删除 1-删除
		///</summary>
		
		private int? deleteFlag_;
		
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
		public com.vip.xstore.user.face.service.common.PageInfo GetPageInfo(){
			return this.pageInfo_;
		}
		
		public void SetPageInfo(com.vip.xstore.user.face.service.common.PageInfo value){
			this.pageInfo_ = value;
		}
		public string GetPosCode(){
			return this.posCode_;
		}
		
		public void SetPosCode(string value){
			this.posCode_ = value;
		}
		public string GetDzStoreCode(){
			return this.dzStoreCode_;
		}
		
		public void SetDzStoreCode(string value){
			this.dzStoreCode_ = value;
		}
		public string GetRegionCode(){
			return this.regionCode_;
		}
		
		public void SetRegionCode(string value){
			this.regionCode_ = value;
		}
		public string GetCityCode(){
			return this.cityCode_;
		}
		
		public void SetCityCode(string value){
			this.cityCode_ = value;
		}
		public string GetProvinceCode(){
			return this.provinceCode_;
		}
		
		public void SetProvinceCode(string value){
			this.provinceCode_ = value;
		}
		public int? GetDeleteFlag(){
			return this.deleteFlag_;
		}
		
		public void SetDeleteFlag(int? value){
			this.deleteFlag_ = value;
		}
		
	}
	
}