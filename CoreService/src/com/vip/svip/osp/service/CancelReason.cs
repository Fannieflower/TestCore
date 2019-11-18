using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.svip.osp.service{
	
	
	
	
	
	public class CancelReason {
		
		///<summary>
		/// 原因类型
		///</summary>
		
		private int? reasonId_;
		
		///<summary>
		/// 指标
		///</summary>
		
		private string quota_;
		
		///<summary>
		/// json格式详情
		///</summary>
		
		private string detail_;
		
		public int? GetReasonId(){
			return this.reasonId_;
		}
		
		public void SetReasonId(int? value){
			this.reasonId_ = value;
		}
		public string GetQuota(){
			return this.quota_;
		}
		
		public void SetQuota(string value){
			this.quota_ = value;
		}
		public string GetDetail(){
			return this.detail_;
		}
		
		public void SetDetail(string value){
			this.detail_ = value;
		}
		
	}
	
}