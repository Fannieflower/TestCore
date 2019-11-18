using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.vop.cup.api.aftersale{
	
	
	
	
	
	public class GetReturnApplyStatusResp {
		
		///<summary>
		/// 在按时间范围查询时，如果超过单页最大数（100）时会分页返回。
		///</summary>
		
		private List<com.vip.vop.cup.api.aftersale.ReturnApplyStatusInfo> return_apply_status_info_;
		
		///<summary>
		/// 处理结果（全部成功则返回200，只要一条记录处理失败则返回400208)status： 200， message：操作成功status：400208，message：部分或全部记录处理失败
		///</summary>
		
		private com.vip.vop.cup.api.aftersale.Result result_;
		
		public List<com.vip.vop.cup.api.aftersale.ReturnApplyStatusInfo> GetReturn_apply_status_info(){
			return this.return_apply_status_info_;
		}
		
		public void SetReturn_apply_status_info(List<com.vip.vop.cup.api.aftersale.ReturnApplyStatusInfo> value){
			this.return_apply_status_info_ = value;
		}
		public com.vip.vop.cup.api.aftersale.Result GetResult(){
			return this.result_;
		}
		
		public void SetResult(com.vip.vop.cup.api.aftersale.Result value){
			this.result_ = value;
		}
		
	}
	
}