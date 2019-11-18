using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.vis.purchase.schedules.service.query{
	
	
	
	
	
	public class QueryApplySellingResponse {
		
		///<summary>
		/// 返回码
		///</summary>
		
		private int? code_;
		
		///<summary>
		/// 返回信息
		///</summary>
		
		private string msg_;
		
		///<summary>
		/// 总数
		///</summary>
		
		private int? totalNum_;
		
		///<summary>
		/// 采购协议数据结构
		///</summary>
		
		private List<com.vip.vis.purchase.schedules.service.query.ApplySellingData> applySellingDataList_;
		
		///<summary>
		/// 一页可以查询的最大数量
		///</summary>
		
		private int? pageSize_;
		
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
		public int? GetTotalNum(){
			return this.totalNum_;
		}
		
		public void SetTotalNum(int? value){
			this.totalNum_ = value;
		}
		public List<com.vip.vis.purchase.schedules.service.query.ApplySellingData> GetApplySellingDataList(){
			return this.applySellingDataList_;
		}
		
		public void SetApplySellingDataList(List<com.vip.vis.purchase.schedules.service.query.ApplySellingData> value){
			this.applySellingDataList_ = value;
		}
		public int? GetPageSize(){
			return this.pageSize_;
		}
		
		public void SetPageSize(int? value){
			this.pageSize_ = value;
		}
		
	}
	
}