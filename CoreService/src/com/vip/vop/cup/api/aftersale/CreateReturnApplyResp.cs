using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.vop.cup.api.aftersale{
	
	
	
	
	
	public class CreateReturnApplyResp {
		
		///<summary>
		/// 处理结果（全部成功则返回200，只要一条记录处理失败则返回400208）status： 200， message：操作成功status：400208，message：部分或全部记录处理失败
		///</summary>
		
		private com.vip.vop.cup.api.aftersale.Result result_;
		
		///<summary>
		/// 成功入库的申请单列表，不代表业务成功处理了
		///</summary>
		
		private List<string> succ_apply_ids_;
		
		///<summary>
		/// 入库失败的申请单列表，
		///</summary>
		
		private List<com.vip.vop.cup.api.aftersale.FailedApply> failed_apply_ids_;
		
		public com.vip.vop.cup.api.aftersale.Result GetResult(){
			return this.result_;
		}
		
		public void SetResult(com.vip.vop.cup.api.aftersale.Result value){
			this.result_ = value;
		}
		public List<string> GetSucc_apply_ids(){
			return this.succ_apply_ids_;
		}
		
		public void SetSucc_apply_ids(List<string> value){
			this.succ_apply_ids_ = value;
		}
		public List<com.vip.vop.cup.api.aftersale.FailedApply> GetFailed_apply_ids(){
			return this.failed_apply_ids_;
		}
		
		public void SetFailed_apply_ids(List<com.vip.vop.cup.api.aftersale.FailedApply> value){
			this.failed_apply_ids_ = value;
		}
		
	}
	
}