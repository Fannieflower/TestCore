using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.vop.cup.api.aftersale{
	
	
	
	
	
	public class CreateReturnApplyReq {
		
		///<summary>
		/// 退货申请
		///</summary>
		
		private com.vip.vop.cup.api.aftersale.ReturnApply return_apply_;
		
		///<summary>
		/// 退货商品
		///</summary>
		
		private List<com.vip.vop.cup.api.aftersale.ReturnApplyGood> return_apply_goods_;
		
		///<summary>
		/// 售后申请人
		///</summary>
		
		private com.vip.vop.cup.api.aftersale.Consignee consignee_;
		
		public com.vip.vop.cup.api.aftersale.ReturnApply GetReturn_apply(){
			return this.return_apply_;
		}
		
		public void SetReturn_apply(com.vip.vop.cup.api.aftersale.ReturnApply value){
			this.return_apply_ = value;
		}
		public List<com.vip.vop.cup.api.aftersale.ReturnApplyGood> GetReturn_apply_goods(){
			return this.return_apply_goods_;
		}
		
		public void SetReturn_apply_goods(List<com.vip.vop.cup.api.aftersale.ReturnApplyGood> value){
			this.return_apply_goods_ = value;
		}
		public com.vip.vop.cup.api.aftersale.Consignee GetConsignee(){
			return this.consignee_;
		}
		
		public void SetConsignee(com.vip.vop.cup.api.aftersale.Consignee value){
			this.consignee_ = value;
		}
		
	}
	
}