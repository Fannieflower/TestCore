using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.vipapis.productsale.service{
	
	
	
	
	
	public class ProductSaleParam {
		
		///<summary>
		/// 供应商ID
		///</summary>
		
		private string vendorId_;
		
		///<summary>
		/// 查询起始时间，单位毫秒
		///</summary>
		
		private long? startTime_;
		
		///<summary>
		/// 查询结束时间，单位毫秒
		///</summary>
		
		private long? endTime_;
		
		///<summary>
		/// 页码
		/// @sampleValue page page=1
		///</summary>
		
		private int? page_;
		
		///<summary>
		/// 每页记录数
		/// @sampleValue limit limit=1000
		///</summary>
		
		private int? limit_;
		
		public string GetVendorId(){
			return this.vendorId_;
		}
		
		public void SetVendorId(string value){
			this.vendorId_ = value;
		}
		public long? GetStartTime(){
			return this.startTime_;
		}
		
		public void SetStartTime(long? value){
			this.startTime_ = value;
		}
		public long? GetEndTime(){
			return this.endTime_;
		}
		
		public void SetEndTime(long? value){
			this.endTime_ = value;
		}
		public int? GetPage(){
			return this.page_;
		}
		
		public void SetPage(int? value){
			this.page_ = value;
		}
		public int? GetLimit(){
			return this.limit_;
		}
		
		public void SetLimit(int? value){
			this.limit_ = value;
		}
		
	}
	
}