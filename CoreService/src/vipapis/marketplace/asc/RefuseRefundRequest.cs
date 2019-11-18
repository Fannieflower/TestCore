using System;
using System.Collections.Generic;
using System.Text;

namespace vipapis.marketplace.asc{
	
	
	
	
	
	public class RefuseRefundRequest {
		
		///<summary>
		/// 售后申请单号
		///</summary>
		
		private string asc_sn_;
		
		///<summary>
		/// 售后明细id
		///</summary>
		
		private string asc_product_id_;
		
		///<summary>
		/// 拒绝退款的意见
		///</summary>
		
		private string opinion_;
		
		///<summary>
		/// 操作人信息
		///</summary>
		
		private string operator_;
		
		public string GetAsc_sn(){
			return this.asc_sn_;
		}
		
		public void SetAsc_sn(string value){
			this.asc_sn_ = value;
		}
		public string GetAsc_product_id(){
			return this.asc_product_id_;
		}
		
		public void SetAsc_product_id(string value){
			this.asc_product_id_ = value;
		}
		public string GetOpinion(){
			return this.opinion_;
		}
		
		public void SetOpinion(string value){
			this.opinion_ = value;
		}
		public string GetOperator(){
			return this.operator_;
		}
		
		public void SetOperator(string value){
			this.operator_ = value;
		}
		
	}
	
}