using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.xstore.inventory.service.wop{
	
	
	
	
	
	public class WopInvChgRsp {
		
		///<summary>
		/// 业务流水号
		///</summary>
		
		private string seqNo_;
		
		///<summary>
		/// 处理结果,200-成功,其他参见:http://wiki.corp.vipshop.com/pages/viewpage.action?pageId=728663318#SIMS-%E6%8E%A5%E5%85%A5WOP%E6%B5%81%E6%B0%B4%28%E6%9A%A8530%E5%A4%A7%E6%94%B9%E7%89%88%E8%AF%A6%E7%BB%86%E8%AE%BE%E8%AE%A1%29-2.3%E5%BA%93%E5%AD%98%E5%A4%84%E7%90%86%E7%BB%93%E6%9E%9C
		///</summary>
		
		private int? code_;
		
		///<summary>
		/// 处理结果描述
		///</summary>
		
		private string msg_;
		
		public string GetSeqNo(){
			return this.seqNo_;
		}
		
		public void SetSeqNo(string value){
			this.seqNo_ = value;
		}
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
		
	}
	
}