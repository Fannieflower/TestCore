using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.pms.data.service{
	
	
	
	
	
	public class PmsActConfigModel {
		
		///<summary>
		/// 配置类型
		///</summary>
		
		private int? configType_;
		
		///<summary>
		/// 配置值
		///</summary>
		
		private string configValue_;
		
		///<summary>
		/// 配置说明
		///</summary>
		
		private string configDesc_;
		
		public int? GetConfigType(){
			return this.configType_;
		}
		
		public void SetConfigType(int? value){
			this.configType_ = value;
		}
		public string GetConfigValue(){
			return this.configValue_;
		}
		
		public void SetConfigValue(string value){
			this.configValue_ = value;
		}
		public string GetConfigDesc(){
			return this.configDesc_;
		}
		
		public void SetConfigDesc(string value){
			this.configDesc_ = value;
		}
		
	}
	
}