using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.xstore.user.face.service{
	
	
	
	
	
	public class XstoreCameraInfoModel {
		
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
		/// 创建时间
		///</summary>
		
		private long? createTime_;
		
		///<summary>
		/// 更新时间
		///</summary>
		
		private long? updateTime_;
		
		///<summary>
		/// 是否删除 0-未删除 1-删除，默认0
		///</summary>
		
		private int? deleteFlag_;
		
		///<summary>
		/// 门店名称
		///</summary>
		
		private string storeName_;
		
		///<summary>
		/// 省份编码
		///</summary>
		
		private string provinceCode_;
		
		///<summary>
		/// 省份名称
		///</summary>
		
		private string provinceName_;
		
		///<summary>
		/// 城市名称
		///</summary>
		
		private string cityName_;
		
		///<summary>
		/// 区县编码
		///</summary>
		
		private string districtCode_;
		
		///<summary>
		/// 区县名称
		///</summary>
		
		private string district_;
		
		///<summary>
		/// 联系人
		///</summary>
		
		private string contact_;
		
		///<summary>
		/// 门店电话
		///</summary>
		
		private string contactTel_;
		
		///<summary>
		/// 门店手机
		///</summary>
		
		private string contactMobile_;
		
		///<summary>
		/// 邮编
		///</summary>
		
		private string zipCode_;
		
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
		public long? GetCreateTime(){
			return this.createTime_;
		}
		
		public void SetCreateTime(long? value){
			this.createTime_ = value;
		}
		public long? GetUpdateTime(){
			return this.updateTime_;
		}
		
		public void SetUpdateTime(long? value){
			this.updateTime_ = value;
		}
		public int? GetDeleteFlag(){
			return this.deleteFlag_;
		}
		
		public void SetDeleteFlag(int? value){
			this.deleteFlag_ = value;
		}
		public string GetStoreName(){
			return this.storeName_;
		}
		
		public void SetStoreName(string value){
			this.storeName_ = value;
		}
		public string GetProvinceCode(){
			return this.provinceCode_;
		}
		
		public void SetProvinceCode(string value){
			this.provinceCode_ = value;
		}
		public string GetProvinceName(){
			return this.provinceName_;
		}
		
		public void SetProvinceName(string value){
			this.provinceName_ = value;
		}
		public string GetCityName(){
			return this.cityName_;
		}
		
		public void SetCityName(string value){
			this.cityName_ = value;
		}
		public string GetDistrictCode(){
			return this.districtCode_;
		}
		
		public void SetDistrictCode(string value){
			this.districtCode_ = value;
		}
		public string GetDistrict(){
			return this.district_;
		}
		
		public void SetDistrict(string value){
			this.district_ = value;
		}
		public string GetContact(){
			return this.contact_;
		}
		
		public void SetContact(string value){
			this.contact_ = value;
		}
		public string GetContactTel(){
			return this.contactTel_;
		}
		
		public void SetContactTel(string value){
			this.contactTel_ = value;
		}
		public string GetContactMobile(){
			return this.contactMobile_;
		}
		
		public void SetContactMobile(string value){
			this.contactMobile_ = value;
		}
		public string GetZipCode(){
			return this.zipCode_;
		}
		
		public void SetZipCode(string value){
			this.zipCode_ = value;
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
		
	}
	
}