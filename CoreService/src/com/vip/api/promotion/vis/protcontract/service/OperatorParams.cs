using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.api.promotion.vis.protcontract.service{
	
	
	
	
	
	public class OperatorParams {
		
		///<summary>
		/// 操作人类型（1：供应商；2：商助）
		///</summary>
		
		private byte? operatorType_;
		
		///<summary>
		/// 操作人id
		///</summary>
		
		private int? operatorId_;
		
		///<summary>
		/// 操作人昵称
		///</summary>
		
		private string operatorNickname_;
		
		public byte? GetOperatorType(){
			return this.operatorType_;
		}
		
		public void SetOperatorType(byte? value){
			this.operatorType_ = value;
		}
		public int? GetOperatorId(){
			return this.operatorId_;
		}
		
		public void SetOperatorId(int? value){
			this.operatorId_ = value;
		}
		public string GetOperatorNickname(){
			return this.operatorNickname_;
		}
		
		public void SetOperatorNickname(string value){
			this.operatorNickname_ = value;
		}
		
	}
	
}