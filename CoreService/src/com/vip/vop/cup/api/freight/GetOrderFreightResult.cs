using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.vop.cup.api.freight{
	
	
	
	
	
	public class GetOrderFreightResult {
		
		///<summary>
		/// 响应编码
		///</summary>
		
		private string result_code_;
		
		///<summary>
		/// 响应描述
		///</summary>
		
		private string result_msg_;
		
		///<summary>
		/// 运费信息列表
		///</summary>
		
		private List<com.vip.vop.cup.api.freight.FreightInfo> freight_info_list_;
		
		public string GetResult_code(){
			return this.result_code_;
		}
		
		public void SetResult_code(string value){
			this.result_code_ = value;
		}
		public string GetResult_msg(){
			return this.result_msg_;
		}
		
		public void SetResult_msg(string value){
			this.result_msg_ = value;
		}
		public List<com.vip.vop.cup.api.freight.FreightInfo> GetFreight_info_list(){
			return this.freight_info_list_;
		}
		
		public void SetFreight_info_list(List<com.vip.vop.cup.api.freight.FreightInfo> value){
			this.freight_info_list_ = value;
		}
		
	}
	
}