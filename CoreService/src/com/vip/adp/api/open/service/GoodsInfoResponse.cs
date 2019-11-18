using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.adp.api.open.service{
	
	
	
	
	
	public class GoodsInfoResponse {
		
		///<summary>
		/// 精选商品列表
		///</summary>
		
		private List<com.vip.adp.api.open.service.GoodsInfo> goodsInfoList_;
		
		///<summary>
		/// 总数
		///</summary>
		
		private int? total_;
		
		///<summary>
		/// 支持的排序字段,为空时仅支持默认排序
		///</summary>
		
		private List<com.vip.adp.api.open.service.SortField> sortFields_;
		
		///<summary>
		/// 当前页码
		///</summary>
		
		private int? page_;
		
		///<summary>
		/// 分页大小
		///</summary>
		
		private int? pageSize_;
		
		public List<com.vip.adp.api.open.service.GoodsInfo> GetGoodsInfoList(){
			return this.goodsInfoList_;
		}
		
		public void SetGoodsInfoList(List<com.vip.adp.api.open.service.GoodsInfo> value){
			this.goodsInfoList_ = value;
		}
		public int? GetTotal(){
			return this.total_;
		}
		
		public void SetTotal(int? value){
			this.total_ = value;
		}
		public List<com.vip.adp.api.open.service.SortField> GetSortFields(){
			return this.sortFields_;
		}
		
		public void SetSortFields(List<com.vip.adp.api.open.service.SortField> value){
			this.sortFields_ = value;
		}
		public int? GetPage(){
			return this.page_;
		}
		
		public void SetPage(int? value){
			this.page_ = value;
		}
		public int? GetPageSize(){
			return this.pageSize_;
		}
		
		public void SetPageSize(int? value){
			this.pageSize_ = value;
		}
		
	}
	
}