using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.vop.cup.api.aftersale{
	
	
	
	
	
	public class UpdateReturnApplyStatusResp {
		
		///<summary>
		/// 入库成功的申请单ID列表
		///</summary>
		
		private List<string> succ_apply_ids_;
		
		///<summary>
		/// 入库失败的申请单ID列表
		///</summary>
		
		private List<com.vip.vop.cup.api.aftersale.FailedApply> failed_apply_ids_;
		
		///<summary>
		/// 处理结果
		///</summary>
		
		private com.vip.vop.cup.api.aftersale.Result result_;
		
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
		public com.vip.vop.cup.api.aftersale.Result GetResult(){
			return this.result_;
		}
		
		public void SetResult(com.vip.vop.cup.api.aftersale.Result value){
			this.result_ = value;
		}
		
	}
	
}