using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.svip.osp.service{
	
	
	
	
	
	public class GetSvipGoodsResult {
		
		///<summary>
		/// code
		///</summary>
		
		private int? code_;
		
		///<summary>
		/// msg
		///</summary>
		
		private string msg_;
		
		///<summary>
		/// svip商品信息
		///</summary>
		
		private com.vip.svip.osp.service.SvipGoodsBPInfo data_;
		
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
		public com.vip.svip.osp.service.SvipGoodsBPInfo GetData(){
			return this.data_;
		}
		
		public void SetData(com.vip.svip.osp.service.SvipGoodsBPInfo value){
			this.data_ = value;
		}
		
	}
	
}