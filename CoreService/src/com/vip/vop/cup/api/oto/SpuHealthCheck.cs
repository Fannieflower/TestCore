using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.vop.cup.api.oto{
	
	
	
	
	
	public class SpuHealthCheck {
		
		///<summary>
		/// SPU ID
		///</summary>
		
		private long? v_spu_id_;
		
		///<summary>
		/// 商品资料健康度，例如：80%
		///</summary>
		
		private string health_check_percentage_;
		
		///<summary>
		/// 资料健康问题描述
		///</summary>
		
		private string health_check_detail_;
		
		///<summary>
		/// 是否可上架，0 可上架，1不可上架
		///</summary>
		
		private int? health_check_;
		
		///<summary>
		/// 商品资料健康度风险等级 0 不存在问题 1 存在高风险问题 2 存在低风险问题 3 存在中风险问题
		///</summary>
		
		private int? riskLevel_;
		
		///<summary>
		/// 错误码信息
		///</summary>
		
		private com.vip.vop.cup.api.oto.ErrorCodeMessage error_code_message_;
		
		///<summary>
		/// 资料健康问题描述列表
		///</summary>
		
		private List<com.vip.vop.cup.api.oto.HealthCheckDetail> health_check_detail_list_;
		
		public long? GetV_spu_id(){
			return this.v_spu_id_;
		}
		
		public void SetV_spu_id(long? value){
			this.v_spu_id_ = value;
		}
		public string GetHealth_check_percentage(){
			return this.health_check_percentage_;
		}
		
		public void SetHealth_check_percentage(string value){
			this.health_check_percentage_ = value;
		}
		public string GetHealth_check_detail(){
			return this.health_check_detail_;
		}
		
		public void SetHealth_check_detail(string value){
			this.health_check_detail_ = value;
		}
		public int? GetHealth_check(){
			return this.health_check_;
		}
		
		public void SetHealth_check(int? value){
			this.health_check_ = value;
		}
		public int? GetRiskLevel(){
			return this.riskLevel_;
		}
		
		public void SetRiskLevel(int? value){
			this.riskLevel_ = value;
		}
		public com.vip.vop.cup.api.oto.ErrorCodeMessage GetError_code_message(){
			return this.error_code_message_;
		}
		
		public void SetError_code_message(com.vip.vop.cup.api.oto.ErrorCodeMessage value){
			this.error_code_message_ = value;
		}
		public List<com.vip.vop.cup.api.oto.HealthCheckDetail> GetHealth_check_detail_list(){
			return this.health_check_detail_list_;
		}
		
		public void SetHealth_check_detail_list(List<com.vip.vop.cup.api.oto.HealthCheckDetail> value){
			this.health_check_detail_list_ = value;
		}
		
	}
	
}