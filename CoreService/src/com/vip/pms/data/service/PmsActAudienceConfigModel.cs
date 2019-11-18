using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.pms.data.service{
	
	
	
	
	
	public class PmsActAudienceConfigModel {
		
		///<summary>
		/// 受众类型
		///</summary>
		
		private int? audienceType_;
		
		///<summary>
		/// 受众配置项
		///</summary>
		
		private string audienceConfig_;
		
		///<summary>
		/// 受众配置值
		///</summary>
		
		private List<string> configValueList_;
		
		///<summary>
		/// 配置说明
		///</summary>
		
		private string configDesc_;
		
		public int? GetAudienceType(){
			return this.audienceType_;
		}
		
		public void SetAudienceType(int? value){
			this.audienceType_ = value;
		}
		public string GetAudienceConfig(){
			return this.audienceConfig_;
		}
		
		public void SetAudienceConfig(string value){
			this.audienceConfig_ = value;
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