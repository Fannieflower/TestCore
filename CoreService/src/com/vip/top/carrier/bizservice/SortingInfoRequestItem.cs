using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.top.carrier.bizservice{
	
	
	
	
	
	public class SortingInfoRequestItem {
		
		///<summary>
		/// 省
		///</summary>
		
		private string province_;
		
		///<summary>
		/// 城市
		///</summary>
		
		private string city_;
		
		///<summary>
		/// 区/县
		///</summary>
		
		private string area_;
		
		///<summary>
		/// 乡镇/街道
		///</summary>
		
		private string town_;
		
		///<summary>
		/// 详细地址
		///</summary>
		
		private string address_;
		
		///<summary>
		/// 预计出仓时间
		///</summary>
		
		private string preOutTime_;
		
		///<summary>
		/// 备注字段
		///</summary>
		
		private string remark_;
		
		///<summary>
		/// 参考单号
		///</summary>
		
		private string referenceNo_;
		
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
		public string GetArea(){
			return this.area_;
		}
		
		public void SetArea(string value){
			this.area_ = value;
		}
		public string GetTown(){
			return this.town_;
		}
		
		public void SetTown(string value){
			this.town_ = value;
		}
		public string GetAddress(){
			return this.address_;
		}
		
		public void SetAddress(string value){
			this.address_ = value;
		}
		public string GetPreOutTime(){
			return this.preOutTime_;
		}
		
		public void SetPreOutTime(string value){
			this.preOutTime_ = value;
		}
		public string GetRemark(){
			return this.remark_;
		}
		
		public void SetRemark(string value){
			this.remark_ = value;
		}
		public string GetReferenceNo(){
			return this.referenceNo_;
		}
		
		public void SetReferenceNo(string value){
			this.referenceNo_ = value;
		}
		
	}
	
}