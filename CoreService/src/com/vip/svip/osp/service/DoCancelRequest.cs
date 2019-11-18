using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.svip.osp.service{
	
	
	
	
	
	public class DoCancelRequest {
		
		///<summary>
		/// 用户id
		///</summary>
		
		private long? userId_;
		
		///<summary>
		/// 原因
		///</summary>
		
		private string reasonText_;
		
		///<summary>
		/// oa账号
		///</summary>
		
		private string oaAccount_;
		
		///<summary>
		/// oa工号
		///</summary>
		
		private string oaNo_;
		
		///<summary>
		/// 操作方
		///</summary>
		
		private string operator_;
		
		///<summary>
		/// 验签
		///</summary>
		
		private string sign_;
		
		///<summary>
		/// 批次号
		///</summary>
		
		private long? batchNo_;
		
		public long? GetUserId(){
			return this.userId_;
		}
		
		public void SetUserId(long? value){
			this.userId_ = value;
		}
		public string GetReasonText(){
			return this.reasonText_;
		}
		
		public void SetReasonText(string value){
			this.reasonText_ = value;
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
		public string GetSign(){
			return this.sign_;
		}
		
		public void SetSign(string value){
			this.sign_ = value;
		}
		public long? GetBatchNo(){
			return this.batchNo_;
		}
		
		public void SetBatchNo(long? value){
			this.batchNo_ = value;
		}
		
	}
	
}