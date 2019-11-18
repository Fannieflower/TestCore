using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.pms.data.service{
	
	
	
	
	
	public class AdminConfigModel {
		
		///<summary>
		/// 配置ID
		///</summary>
		
		private int? id_;
		
		///<summary>
		/// 配置域 0:all;1:oca;2:tips;3:active;4:data;5:coupon
		///</summary>
		
		private string configType_;
		
		///<summary>
		/// 配置key
		///</summary>
		
		private string configKey_;
		
		///<summary>
		/// 配置val
		///</summary>
		
		private string configValue_;
		
		///<summary>
		/// 创建时间
		///</summary>
		
		private long? createTime_;
		
		///<summary>
		/// 修改时间
		///</summary>
		
		private long? updateTime_;
		
		public int? GetId(){
			return this.id_;
		}
		
		public void SetId(int? value){
			this.id_ = value;
		}
		public string GetConfigType(){
			return this.configType_;
		}
		
		public void SetConfigType(string value){
			this.configType_ = value;
		}
		public string GetConfigKey(){
			return this.configKey_;
		}
		
		public void SetConfigKey(string value){
			this.configKey_ = value;
		}
		public string GetConfigValue(){
			return this.configValue_;
		}
		
		public void SetConfigValue(string value){
			this.configValue_ = value;
		}
		public long? GetCreateTime(){
			return this.createTime_;
		}
		
		public void SetCreateTime(long? value){
			this.createTime_ = value;
		}
		public long? GetUpdateTime(){
			return this.updateTime_;
		}
		
		public void SetUpdateTime(long? value){
			this.updateTime_ = value;
		}
		
	}
	
}