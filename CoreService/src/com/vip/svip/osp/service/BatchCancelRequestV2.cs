using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.svip.osp.service{
	
	
	
	
	
	public class BatchCancelRequestV2 {
		
		///<summary>
		/// 批次号
		///</summary>
		
		private string batchNo_;
		
		///<summary>
		/// oa账号
		///</summary>
		
		private string oaAccount_;
		
		///<summary>
		/// oa工号
		///</summary>
		
		private string oaNo_;
		
		///<summary>
		/// 调用方
		///</summary>
		
		private string operator_;
		
		///<summary>
		/// 清退用户列表
		///</summary>
		
		private List<com.vip.svip.osp.service.CancelUserV2> userList_;
		
		public string GetBatchNo(){
			return this.batchNo_;
		}
		
		public void SetBatchNo(string value){
			this.batchNo_ = value;
		}
		public string GetOaAccount(){
			return this.oaAccount_;
		}
		
		public void SetOaAccount(string value){
			this.oaAccount_ = value;
		}
		public string GetOaNo(){
			return this.oaNo_;
		}
		
		public void SetOaNo(string value){
			this.oaNo_ = value;
		}
		public string GetOperator(){
			return this.operator_;
		}
		
		public void SetOperator(string value){
			this.operator_ = value;
		}
		public List<com.vip.svip.osp.service.CancelUserV2> GetUserList(){
			return this.userList_;
		}
		
		public void SetUserList(List<com.vip.svip.osp.service.CancelUserV2> value){
			this.userList_ = value;
		}
		
	}
	
}