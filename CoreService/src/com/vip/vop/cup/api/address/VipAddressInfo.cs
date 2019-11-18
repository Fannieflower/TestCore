using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.vop.cup.api.address{
	
	
	
	
	
	public class VipAddressInfo {
		
		///<summary>
		/// 省代码
		///</summary>
		
		private string province_;
		
		///<summary>
		/// 城市代码
		///</summary>
		
		private string city_;
		
		///<summary>
		/// 区/县代码
		///</summary>
		
		private string county_;
		
		///<summary>
		/// 镇/街道代码
		///</summary>
		
		private string street_;
		
		///<summary>
		/// 整体地址编码
		///</summary>
		
		private string areaId_;
		
		public string GetProvince(){
			return this.province_;
		}
		
		public void SetProvince(string value){
			this.province_ = value;
		}
		public string GetCity(){
			return this.city_;
		}
		
		public void SetCity(string value){
			this.city_ = value;
		}
		public string GetCounty(){
			return this.county_;
		}
		
		public void SetCounty(string value){
			this.county_ = value;
		}
		public string GetStreet(){
			return this.street_;
		}
		
		public void SetStreet(string value){
			this.street_ = value;
		}
		public string GetAreaId(){
			return this.areaId_;
		}
		
		public void SetAreaId(string value){
			this.areaId_ = value;
		}
		
	}
	
}