using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.xstore.cc.bulkbuying.service{
	
	
	
	
	
	public class XStoreAddressModel {
		
		///<summary>
		/// id
		///</summary>
		
		private long? id_;
		
		///<summary>
		/// 公司编码(xstorebuy/maxxbuy)
		///</summary>
		
		private string companyCode_;
		
		///<summary>
		/// 地址名
		///</summary>
		
		private string title_;
		
		///<summary>
		/// 仓库编码
		///</summary>
		
		private string warehouseCode_;
		
		///<summary>
		/// 三级地址码
		///</summary>
		
		private string areaId_;
		
		///<summary>
		/// 省市区
		///</summary>
		
		private string pcd_;
		
		///<summary>
		/// 地址
		///</summary>
		
		private string address_;
		
		///<summary>
		/// 邮编
		///</summary>
		
		private string postcode_;
		
		///<summary>
		/// 联系电话
		///</summary>
		
		private string tel_;
		
		///<summary>
		/// 电子邮件
		///</summary>
		
		private string email_;
		
		///<summary>
		/// 联系人
		///</summary>
		
		private string linker_;
		
		///<summary>
		/// 备注
		///</summary>
		
		private string remark_;
		
		///<summary>
		/// 省ID
		///</summary>
		
		private string provinceId_;
		
		///<summary>
		/// 地市ID
		///</summary>
		
		private string cityId_;
		
		///<summary>
		/// 省
		///</summary>
		
		private string provinceName_;
		
		///<summary>
		/// 市
		///</summary>
		
		private string cityName_;
		
		///<summary>
		/// 区
		///</summary>
		
		private string districtName_;
		
		public long? GetId(){
			return this.id_;
		}
		
		public void SetId(long? value){
			this.id_ = value;
		}
		public string GetCompanyCode(){
			return this.companyCode_;
		}
		
		public void SetCompanyCode(string value){
			this.companyCode_ = value;
		}
		public string GetTitle(){
			return this.title_;
		}
		
		public void SetTitle(string value){
			this.title_ = value;
		}
		public string GetWarehouseCode(){
			return this.warehouseCode_;
		}
		
		public void SetWarehouseCode(string value){
			this.warehouseCode_ = value;
		}
		public string GetAreaId(){
			return this.areaId_;
		}
		
		public void SetAreaId(string value){
			this.areaId_ = value;
		}
		public string GetPcd(){
			return this.pcd_;
		}
		
		public void SetPcd(string value){
			this.pcd_ = value;
		}
		public string GetAddress(){
			return this.address_;
		}
		
		public void SetAddress(string value){
			this.address_ = value;
		}
		public string GetPostcode(){
			return this.postcode_;
		}
		
		public void SetPostcode(string value){
			this.postcode_ = value;
		}
		public string GetTel(){
			return this.tel_;
		}
		
		public void SetTel(string value){
			this.tel_ = value;
		}
		public string GetEmail(){
			return this.email_;
		}
		
		public void SetEmail(string value){
			this.email_ = value;
		}
		public string GetLinker(){
			return this.linker_;
		}
		
		public void SetLinker(string value){
			this.linker_ = value;
		}
		public string GetRemark(){
			return this.remark_;
		}
		
		public void SetRemark(string value){
			this.remark_ = value;
		}
		public string GetProvinceId(){
			return this.provinceId_;
		}
		
		public void SetProvinceId(string value){
			this.provinceId_ = value;
		}
		public string GetCityId(){
			return this.cityId_;
		}
		
		public void SetCityId(string value){
			this.cityId_ = value;
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
		public string GetDistrictName(){
			return this.districtName_;
		}
		
		public void SetDistrictName(string value){
			this.districtName_ = value;
		}
		
	}
	
}