using System;
using System.Collections.Generic;
using System.Text;

namespace vipapis.puma{
	
	
	
	
	
	public class ProductQueryRequest {
		
		///<summary>
		/// 分页结构体
		///</summary>
		
		private vipapis.puma.Pagination pagination_;
		
		///<summary>
		/// 商品ID列表，最多100个
		///</summary>
		
		private List<long?> product_ids_;
		
		///<summary>
		/// 对应的品牌库中的品牌ID，最多10个
		///</summary>
		
		private List<string> brand_sns_;
		
		///<summary>
		/// 三级分类ID，最多10个
		///</summary>
		
		private List<int?> third_level_category_ids_;
		
		///<summary>
		/// 查询类型，可同时支持多个 1、商品运营信息 2、SPU信息 3、价格信息 4、推广页信息 5、库存信息
		///</summary>
		
		private List<int?> query_types_;
		
		///<summary>
		/// 在售状态： 0、在售 1、不在售  不传值：在售与不在售商品都返回
		///</summary>
		
		private int? is_on_sale_;
		
		///<summary>
		/// 商品名称，前后模糊，选填
		///</summary>
		
		private string product_name_;
		
		///<summary>
		/// 价格范围,（支持区间搜索，多个用OR连接），最多10个
		///</summary>
		
		private List<vipapis.puma.NumberRange> price_ranges_;
		
		///<summary>
		/// 商品标签信息，如果需要过滤多个，请同时传多个:0、高佣商品标识 1、限时快抢商品标识 2、 QQ选品专用  4、最后疯抢
		///</summary>
		
		private List<int?> product_tags_;
		
		///<summary>
		/// 排序规则，选填
		///</summary>
		
		private List<vipapis.puma.SortAttr> sort_attres_;
		
		///<summary>
		/// 折扣范围,（支持区间搜索，多个用OR连接），输入1-10 数字，最多10个 
		///</summary>
		
		private List<vipapis.puma.NumberRange> discount_ranges_;
		
		public vipapis.puma.Pagination GetPagination(){
			return this.pagination_;
		}
		
		public void SetPagination(vipapis.puma.Pagination value){
			this.pagination_ = value;
		}
		public List<long?> GetProduct_ids(){
			return this.product_ids_;
		}
		
		public void SetProduct_ids(List<long?> value){
			this.product_ids_ = value;
		}
		public List<string> GetBrand_sns(){
			return this.brand_sns_;
		}
		
		public void SetBrand_sns(List<string> value){
			this.brand_sns_ = value;
		}
		public List<int?> GetThird_level_category_ids(){
			return this.third_level_category_ids_;
		}
		
		public void SetThird_level_category_ids(List<int?> value){
			this.third_level_category_ids_ = value;
		}
		public List<int?> GetQuery_types(){
			return this.query_types_;
		}
		
		public void SetQuery_types(List<int?> value){
			this.query_types_ = value;
		}
		public int? GetIs_on_sale(){
			return this.is_on_sale_;
		}
		
		public void SetIs_on_sale(int? value){
			this.is_on_sale_ = value;
		}
		public string GetProduct_name(){
			return this.product_name_;
		}
		
		public void SetProduct_name(string value){
			this.product_name_ = value;
		}
		public List<vipapis.puma.NumberRange> GetPrice_ranges(){
			return this.price_ranges_;
		}
		
		public void SetPrice_ranges(List<vipapis.puma.NumberRange> value){
			this.price_ranges_ = value;
		}
		public List<int?> GetProduct_tags(){
			return this.product_tags_;
		}
		
		public void SetProduct_tags(List<int?> value){
			this.product_tags_ = value;
		}
		public List<vipapis.puma.SortAttr> GetSort_attres(){
			return this.sort_attres_;
		}
		
		public void SetSort_attres(List<vipapis.puma.SortAttr> value){
			this.sort_attres_ = value;
		}
		public List<vipapis.puma.NumberRange> GetDiscount_ranges(){
			return this.discount_ranges_;
		}
		
		public void SetDiscount_ranges(List<vipapis.puma.NumberRange> value){
			this.discount_ranges_ = value;
		}
		
	}
	
}