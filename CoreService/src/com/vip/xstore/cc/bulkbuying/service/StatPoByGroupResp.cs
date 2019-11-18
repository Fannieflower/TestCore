using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.xstore.cc.bulkbuying.service{
	
	
	
	
	
	public class StatPoByGroupResp {
		
		///<summary>
		/// 分页信息
		///</summary>
		
		private com.vip.xstore.cc.bulkbuying.model.PaginationModel pagination_;
		
		///<summary>
		/// 统计信息
		///</summary>
		
		private List<com.vip.xstore.cc.bulkbuying.service.PoGroup> list_;
		
		///<summary>
		/// 缺少吊牌价的商品
		///</summary>
		
		private List<string> barcodeWithoutTagPrice_;
		
		public com.vip.xstore.cc.bulkbuying.model.PaginationModel GetPagination(){
			return this.pagination_;
		}
		
		public void SetPagination(com.vip.xstore.cc.bulkbuying.model.PaginationModel value){
			this.pagination_ = value;
		}
		public List<com.vip.xstore.cc.bulkbuying.service.PoGroup> GetList(){
			return this.list_;
		}
		
		public void SetList(List<com.vip.xstore.cc.bulkbuying.service.PoGroup> value){
			this.list_ = value;
		}
		public List<string> GetBarcodeWithoutTagPrice(){
			return this.barcodeWithoutTagPrice_;
		}
		
		public void SetBarcodeWithoutTagPrice(List<string> value){
			this.barcodeWithoutTagPrice_ = value;
		}
		
	}
	
}