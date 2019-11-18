using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.vop.logistics.carrier.service{
	
	
	
	
	
	public class ProblemShipping {
		
		///<summary>
		/// 运单号
		///</summary>
		
		private string logistics_no_;
		
		///<summary>
		/// 问题发现时间
		///</summary>
		
		private System.DateTime? op_time_;
		
		///<summary>
		/// 问题描述
		///</summary>
		
		private string desc_;
		
		///<summary>
		/// 承运商问题编码
		///</summary>
		
		private string problem_code_;
		
		public string GetLogistics_no(){
			return this.logistics_no_;
		}
		
		public void SetLogistics_no(string value){
			this.logistics_no_ = value;
		}
		public System.DateTime? GetOp_time(){
			return this.op_time_;
		}
		
		public void SetOp_time(System.DateTime? value){
			this.op_time_ = value;
		}
		public string GetDesc(){
			return this.desc_;
		}
		
		public void SetDesc(string value){
			this.desc_ = value;
		}
		public string GetProblem_code(){
			return this.problem_code_;
		}
		
		public void SetProblem_code(string value){
			this.problem_code_ = value;
		}
		
	}
	
}