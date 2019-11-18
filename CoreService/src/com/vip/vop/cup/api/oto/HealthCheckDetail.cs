using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.vop.cup.api.oto{
	
	
	
	
	
	public class HealthCheckDetail {
		
		///<summary>
		/// 资料健康问题描述Id
		///</summary>
		
		private int? id_;
		
		///<summary>
		/// 问题分类
		///</summary>
		
		private string health_check_class_;
		
		///<summary>
		/// 资料健康问题描述
		///</summary>
		
		private string health_check_detail_;
		
		///<summary>
		/// 问题的原始定义
		///</summary>
		
		private string org_health_check_detail_;
		
		public int? GetId(){
			return this.id_;
		}
		
		public void SetId(int? value){
			this.id_ = value;
		}
		public string GetHealth_check_class(){
			return this.health_check_class_;
		}
		
		public void SetHealth_check_class(string value){
			this.health_check_class_ = value;
		}
		public string GetHealth_check_detail(){
			return this.health_check_detail_;
		}
		
		public void SetHealth_check_detail(string value){
			this.health_check_detail_ = value;
		}
		public string GetOrg_health_check_detail(){
			return this.org_health_check_detail_;
		}
		
		public void SetOrg_health_check_detail(string value){
			this.org_health_check_detail_ = value;
		}
		
	}
	
}