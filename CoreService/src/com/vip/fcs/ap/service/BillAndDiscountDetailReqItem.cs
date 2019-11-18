using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.fcs.ap.service{
	
	
	
	
	
	public class BillAndDiscountDetailReqItem {
		
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
		
		///<summary>
		/// 账单编号,查询指定账单,如果入参中包含账单编号则无需输入查询日期范围
		///</summary>
		
		private string billNumber_;
		
		///<summary>
		/// 账单签发标识,是否查询未签发状态的账单数据。 
		///如需拉取未签发的账单，入参需为Y。
		///如无需拉取，置空。
		///</summary>
		
		private string billStatusFlag_;
		
		///<summary>
		/// 账单头ID, 内部使用
		///</summary>
		
		private List<long?> headerIds_;
		
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
		public string GetBillNumber(){
			return this.billNumber_;
		}
		
		public void SetBillNumber(string value){
			this.billNumber_ = value;
		}
		public string GetBillStatusFlag(){
			return this.billStatusFlag_;
		}
		
		public void SetBillStatusFlag(string value){
			this.billStatusFlag_ = value;
		}
		public List<long?> GetHeaderIds(){
			return this.headerIds_;
		}
		
		public void SetHeaderIds(List<long?> value){
			this.headerIds_ = value;
		}
		
	}
	
}