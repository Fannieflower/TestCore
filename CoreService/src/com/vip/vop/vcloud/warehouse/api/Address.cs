using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.vop.vcloud.warehouse.api{
	
	
	
	
	
	public class Address {
		
		///<summary>
		/// 省编码
		///</summary>
		
		private string provinceCode_;
		
		///<summary>
		/// 省名称
		///</summary>
		
		private string provinceName_;
		
		///<summary>
		/// 城市编码
		///</summary>
		
		private string cityCode_;
		
		///<summary>
		/// 城市名称
		///</summary>
		
		private string cityName_;
		
		///<summary>
		/// 区编码
		///</summary>
		
		private string regionCode_;
		
		///<summary>
		/// 区名称
		///</summary>
		
		private string regionName_;
		
		///<summary>
		/// 地址
		///</summary>
		
		private string address_;
		
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
		public string GetCityCode(){
			return this.cityCode_;
		}
		
		public void SetCityCode(string value){
			this.cityCode_ = value;
		}
		public string GetCityName(){
			return this.cityName_;
		}
		
		public void SetCityName(string value){
			this.cityName_ = value;
		}
		public string GetRegionCode(){
			return this.regionCode_;
		}
		
		public void SetRegionCode(string value){
			this.regionCode_ = value;
		}
		public string GetRegionName(){
			return this.regionName_;
		}
		
		public void SetRegionName(string value){
			this.regionName_ = value;
		}
		public string GetAddress(){
			return this.address_;
		}
		
		public void SetAddress(string value){
			this.address_ = value;
		}
		
	}
	
}