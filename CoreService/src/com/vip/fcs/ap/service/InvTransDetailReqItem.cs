using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.fcs.ap.service{
	
	
	
	
	
	public class InvTransDetailReqItem {
		
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
		/// 业务发生期间,如2018-05或者2019-05
		///</summary>
		
		private string businessPeriod_;
		
		///<summary>
		/// 条码
		///</summary>
		
		private string itemNo_;
		
		///<summary>
		/// 行类型-收退货
		///</summary>
		
		private string lineType_;
		
		///<summary>
		/// 品牌编码
		///</summary>
		
		private string brandCode_;
		
		///<summary>
		/// 库存属性
		///</summary>
		
		private string whType_;
		
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
		public string GetBusinessPeriod(){
			return this.businessPeriod_;
		}
		
		public void SetBusinessPeriod(string value){
			this.businessPeriod_ = value;
		}
		public string GetItemNo(){
			return this.itemNo_;
		}
		
		public void SetItemNo(string value){
			this.itemNo_ = value;
		}
		public string GetLineType(){
			return this.lineType_;
		}
		
		public void SetLineType(string value){
			this.lineType_ = value;
		}
		public string GetBrandCode(){
			return this.brandCode_;
		}
		
		public void SetBrandCode(string value){
			this.brandCode_ = value;
		}
		public string GetWhType(){
			return this.whType_;
		}
		
		public void SetWhType(string value){
			this.whType_ = value;
		}
		
	}
	
}