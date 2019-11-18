using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.fcs.ap.service{
	
	
	
	
	
	public class VendorDiscountDetailRespItem {
		
		///<summary>
		/// 状态码
		///</summary>
		
		private int? code_;
		
		///<summary>
		/// 返回信息
		///</summary>
		
		private string msg_;
		
		///<summary>
		/// 总数据量
		///</summary>
		
		private long? count_;
		
		///<summary>
		/// 请求参数对象
		///</summary>
		
		private com.vip.fcs.ap.service.BillAndDiscountDetailReqItem billDetailReqItem_;
		
		///<summary>
		/// 满减详情数据
		///</summary>
		
		private List<com.vip.fcs.ap.service.VendorBillDiscountDetail> billDetails_;
		
		public int? GetCode(){
			return this.code_;
		}
		
		public void SetCode(int? value){
			this.code_ = value;
		}
		public string GetMsg(){
			return this.msg_;
		}
		
		public void SetMsg(string value){
			this.msg_ = value;
		}
		public long? GetCount(){
			return this.count_;
		}
		
		public void SetCount(long? value){
			this.count_ = value;
		}
		public com.vip.fcs.ap.service.BillAndDiscountDetailReqItem GetBillDetailReqItem(){
			return this.billDetailReqItem_;
		}
		
		public void SetBillDetailReqItem(com.vip.fcs.ap.service.BillAndDiscountDetailReqItem value){
			this.billDetailReqItem_ = value;
		}
		public List<com.vip.fcs.ap.service.VendorBillDiscountDetail> GetBillDetails(){
			return this.billDetails_;
		}
		
		public void SetBillDetails(List<com.vip.fcs.ap.service.VendorBillDiscountDetail> value){
			this.billDetails_ = value;
		}
		
	}
	
}