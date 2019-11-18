using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.pms.data.service{
	
	
	
	
	
	public class PmsCustomerPageConfigModel {
		
		///<summary>
		/// 配置分流id
		///</summary>
		
		private string configPage_;
		
		///<summary>
		/// 配置分流值
		///</summary>
		
		private List<string> configValueList_;
		
		///<summary>
		/// 配置说明
		///</summary>
		
		private string configDesc_;
		
		public string GetConfigPage(){
			return this.configPage_;
		}
		
		public void SetConfigPage(string value){
			this.configPage_ = value;
		}
		public List<string> GetConfigValueList(){
			return this.configValueList_;
		}
		
		public void SetConfigValueList(List<string> value){
			this.configValueList_ = value;
		}
		public string GetConfigDesc(){
			return this.configDesc_;
		}
		
		public void SetConfigDesc(string value){
			this.configDesc_ = value;
		}
		
	}
	
}