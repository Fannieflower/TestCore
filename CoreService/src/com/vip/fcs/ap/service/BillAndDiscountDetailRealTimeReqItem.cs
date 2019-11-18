using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.fcs.ap.service{
	
	
	
	
	
	public class BillAndDiscountDetailRealTimeReqItem {
		
		///<summary>
		/// 分页对象
		///</summary>
		
		private com.vip.fcs.ap.service.Pager pager_;
		
		///<summary>
		/// 供应商编码
		///</summary>
		
		private string vendorCode_;
		
		///<summary>
		/// PO编号
		///</summary>
		
		private string po_;
		
		///<summary>
		/// 销售明细创建时间start
		///</summary>
		
		private System.DateTime? stQueryTime_;
		
		///<summary>
		/// 销售明细创建时间end
		///</summary>
		
		private System.DateTime? etQueryTime_;
		
		public com.vip.fcs.ap.service.Pager GetPager(){
			return this.pager_;
		}
		
		public void SetPager(com.vip.fcs.ap.service.Pager value){
			this.pager_ = value;
		}
		public string GetVendorCode(){
			return this.vendorCode_;
		}
		
		public void SetVendorCode(string value){
			this.vendorCode_ = value;
		}
		public string GetPo(){
			return this.po_;
		}
		
		public void SetPo(string value){
			this.po_ = value;
		}
		public System.DateTime? GetStQueryTime(){
			return this.stQueryTime_;
		}
		
		public void SetStQueryTime(System.DateTime? value){
			this.stQueryTime_ = value;
		}
		public System.DateTime? GetEtQueryTime(){
			return this.etQueryTime_;
		}
		
		public void SetEtQueryTime(System.DateTime? value){
			this.etQueryTime_ = value;
		}
		
	}
	
}