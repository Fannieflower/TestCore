using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.xstore.user.face.service{
	
	
	
	
	
	public class XstoreCameraUpdateParam {
		
		///<summary>
		/// 自增长主键ID,更新必传
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
		/// 稻知门店编码
		///</summary>
		
		private string dzStoreCode_;
		
		///<summary>
		/// 地区编码
		///</summary>
		
		private string regionCode_;
		
		///<summary>
		/// 城市编码
		///</summary>
		
		private string cityCode_;
		
		///<summary>
		/// 腾讯云区域ID
		///</summary>
		
		private string txRegionCode_;
		
		///<summary>
		/// 腾讯云店铺ID
		///</summary>
		
		private string txStoreCode_;
		
		///<summary>
		/// 摄像头运行状态
		///</summary>
		
		private int? runningState_;
		
		///<summary>
		/// 省份码
		///</summary>
		
		private string provinceCode_;
		
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
		public int? GetRunningState(){
			return this.runningState_;
		}
		
		public void SetRunningState(int? value){
			this.runningState_ = value;
		}
		public string GetProvinceCode(){
			return this.provinceCode_;
		}
		
		public void SetProvinceCode(string value){
			this.provinceCode_ = value;
		}
		
	}
	
}