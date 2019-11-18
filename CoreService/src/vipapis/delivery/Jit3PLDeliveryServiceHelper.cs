using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;

namespace vipapis.delivery{
	
	
	public class Jit3PLDeliveryServiceHelper {
		
		
		
		public class confirmDelivery_args {
			
			///<summary>
			/// 3PL运营商id
			///</summary>
			
			private int? operator_id_;
			
			///<summary>
			/// 入库单号
			///</summary>
			
			private string storage_no_;
			
			///<summary>
			/// 门店编码(门店必写)
			///</summary>
			
			private string store_sn_;
			
			public int? GetOperator_id(){
				return this.operator_id_;
			}
			
			public void SetOperator_id(int? value){
				this.operator_id_ = value;
			}
			public string GetStorage_no(){
				return this.storage_no_;
			}
			
			public void SetStorage_no(string value){
				this.storage_no_ = value;
			}
			public string GetStore_sn(){
				return this.store_sn_;
			}
			
			public void SetStore_sn(string value){
				this.store_sn_ = value;
			}
			
		}
		
		
		
		
		public class createDelivery_args {
			
			///<summary>
			/// 3PL运营商id
			///</summary>
			
			private int? operator_id_;
			
			///<summary>
			/// po号
			///</summary>
			
			private string po_no_;
			
			///<summary>
			/// 运单号
			///</summary>
			
			private string delivery_no_;
			
			///<summary>
			/// 送货仓库
			///</summary>
			
			private vipapis.common.Warehouse? warehouse_;
			
			///<summary>
			/// 送货批次
			/// @sampleValue delivery_time 2014-07-01 10:00:00
			///</summary>
			
			private string delivery_time_;
			
			///<summary>
			/// 要求到货时间(必须是当天或者明天)；空运(delivery_method=2)可选的时间段：9:00:00,16:00:00,18:00:00，23:59:00,20:00:00 ；<br>汽运（delivery_method=1)可选的时间段：2:00:00,9:00:00,16:00:00,19:00:00,20:00:00,22:00:00，23:59:00,10:00:00
			/// @sampleValue arrival_time 2014-07-01 09:00:00
			///</summary>
			
			private string arrival_time_;
			
			///<summary>
			/// 承运商名称
			///</summary>
			
			private string carrier_name_;
			
			///<summary>
			/// 配送方式
			/// @sampleValue delivery_method 1：汽运,2：空运;默认值：1
			///</summary>
			
			private string delivery_method_;
			
			///<summary>
			/// 门店编码
			///</summary>
			
			private string store_sn_;
			
			///<summary>
			/// 承运商编码
			///</summary>
			
			private string carrier_code_;
			
			public int? GetOperator_id(){
				return this.operator_id_;
			}
			
			public void SetOperator_id(int? value){
				this.operator_id_ = value;
			}
			public string GetPo_no(){
				return this.po_no_;
			}
			
			public void SetPo_no(string value){
				this.po_no_ = value;
			}
			public string GetDelivery_no(){
				return this.delivery_no_;
			}
			
			public void SetDelivery_no(string value){
				this.delivery_no_ = value;
			}
			public vipapis.common.Warehouse? GetWarehouse(){
				return this.warehouse_;
			}
			
			public void SetWarehouse(vipapis.common.Warehouse? value){
				this.warehouse_ = value;
			}
			public string GetDelivery_time(){
				return this.delivery_time_;
			}
			
			public void SetDelivery_time(string value){
				this.delivery_time_ = value;
			}
			public string GetArrival_time(){
				return this.arrival_time_;
			}
			
			public void SetArrival_time(string value){
				this.arrival_time_ = value;
			}
			public string GetCarrier_name(){
				return this.carrier_name_;
			}
			
			public void SetCarrier_name(string value){
				this.carrier_name_ = value;
			}
			public string GetDelivery_method(){
				return this.delivery_method_;
			}
			
			public void SetDelivery_method(string value){
				this.delivery_method_ = value;
			}
			public string GetStore_sn(){
				return this.store_sn_;
			}
			
			public void SetStore_sn(string value){
				this.store_sn_ = value;
			}
			public string GetCarrier_code(){
				return this.carrier_code_;
			}
			
			public void SetCarrier_code(string value){
				this.carrier_code_ = value;
			}
			
		}
		
		
		
		
		public class createMultiPoDelivery_args {
			
			///<summary>
			/// 创建出仓单2.0请求
			///</summary>
			
			private vipapis.delivery.Create3PLMultiPoDeliveryRequest request_;
			
			public vipapis.delivery.Create3PLMultiPoDeliveryRequest GetRequest(){
				return this.request_;
			}
			
			public void SetRequest(vipapis.delivery.Create3PLMultiPoDeliveryRequest value){
				this.request_ = value;
			}
			
		}
		
		
		
		
		public class createPick_args {
			
			///<summary>
			/// po单编号,多po用英文逗号分隔
			///</summary>
			
			private string po_no_;
			
			///<summary>
			/// 3PL运营商id
			///</summary>
			
			private int? operator_id_;
			
			///<summary>
			/// 送货仓库,多个仓库用英文逗号相隔开
			///</summary>
			
			private string warehouse_;
			
			///<summary>
			/// 门店编码（OXO模式下填写）
			///</summary>
			
			private string store_sn_;
			
			public string GetPo_no(){
				return this.po_no_;
			}
			
			public void SetPo_no(string value){
				this.po_no_ = value;
			}
			public int? GetOperator_id(){
				return this.operator_id_;
			}
			
			public void SetOperator_id(int? value){
				this.operator_id_ = value;
			}
			public string GetWarehouse(){
				return this.warehouse_;
			}
			
			public void SetWarehouse(string value){
				this.warehouse_ = value;
			}
			public string GetStore_sn(){
				return this.store_sn_;
			}
			
			public void SetStore_sn(string value){
				this.store_sn_ = value;
			}
			
		}
		
		
		
		
		public class deleteDeliveryDetail_args {
			
			///<summary>
			/// 3PL运营商id
			///</summary>
			
			private int? operator_id_;
			
			///<summary>
			/// 入库单号
			///</summary>
			
			private string storage_no_;
			
			///<summary>
			/// po订单号(多个po用英文逗号隔开）
			///</summary>
			
			private string po_no_;
			
			public int? GetOperator_id(){
				return this.operator_id_;
			}
			
			public void SetOperator_id(int? value){
				this.operator_id_ = value;
			}
			public string GetStorage_no(){
				return this.storage_no_;
			}
			
			public void SetStorage_no(string value){
				this.storage_no_ = value;
			}
			public string GetPo_no(){
				return this.po_no_;
			}
			
			public void SetPo_no(string value){
				this.po_no_ = value;
			}
			
		}
		
		
		
		
		public class editDelivery_args {
			
			///<summary>
			/// 3PL运营商id
			///</summary>
			
			private int? operator_id_;
			
			///<summary>
			/// 入库单号
			///</summary>
			
			private string storage_no_;
			
			///<summary>
			/// 运单号
			///</summary>
			
			private string delivery_no_;
			
			///<summary>
			/// 送货仓库
			///</summary>
			
			private vipapis.common.Warehouse? warehouse_;
			
			///<summary>
			/// 送货时间
			/// @sampleValue delivery_time 2014-07-01 10:00:00
			///</summary>
			
			private string delivery_time_;
			
			///<summary>
			/// 要求到货时间，空运(delivery_method=2)可选的时间段：9:00:00,16:00:00,18:00:00,23:59:00,20:00:00 ；<br>汽运（delivery_method=1)可选的时间段：9:00:00,16:00:00,20:00:00,22:00:00,23:59:00,10:00:00
			/// @sampleValue arrival_time 2014-07-01 10:00:00
			///</summary>
			
			private string arrival_time_;
			
			///<summary>
			/// 承运商名称
			///</summary>
			
			private string carrier_name_;
			
			///<summary>
			/// 联系电话
			///</summary>
			
			private string tel_;
			
			///<summary>
			/// 司机姓名
			///</summary>
			
			private string driver_;
			
			///<summary>
			/// 司机联系电话
			///</summary>
			
			private string driver_tel_;
			
			///<summary>
			/// 配送方式
			/// @sampleValue delivery_method 1-汽运,2-空运
			///</summary>
			
			private string delivery_method_;
			
			///<summary>
			/// 门店信息
			///</summary>
			
			private string store_sn_;
			
			///<summary>
			/// 承运商编码
			///</summary>
			
			private string carrier_code_;
			
			public int? GetOperator_id(){
				return this.operator_id_;
			}
			
			public void SetOperator_id(int? value){
				this.operator_id_ = value;
			}
			public string GetStorage_no(){
				return this.storage_no_;
			}
			
			public void SetStorage_no(string value){
				this.storage_no_ = value;
			}
			public string GetDelivery_no(){
				return this.delivery_no_;
			}
			
			public void SetDelivery_no(string value){
				this.delivery_no_ = value;
			}
			public vipapis.common.Warehouse? GetWarehouse(){
				return this.warehouse_;
			}
			
			public void SetWarehouse(vipapis.common.Warehouse? value){
				this.warehouse_ = value;
			}
			public string GetDelivery_time(){
				return this.delivery_time_;
			}
			
			public void SetDelivery_time(string value){
				this.delivery_time_ = value;
			}
			public string GetArrival_time(){
				return this.arrival_time_;
			}
			
			public void SetArrival_time(string value){
				this.arrival_time_ = value;
			}
			public string GetCarrier_name(){
				return this.carrier_name_;
			}
			
			public void SetCarrier_name(string value){
				this.carrier_name_ = value;
			}
			public string GetTel(){
				return this.tel_;
			}
			
			public void SetTel(string value){
				this.tel_ = value;
			}
			public string GetDriver(){
				return this.driver_;
			}
			
			public void SetDriver(string value){
				this.driver_ = value;
			}
			public string GetDriver_tel(){
				return this.driver_tel_;
			}
			
			public void SetDriver_tel(string value){
				this.driver_tel_ = value;
			}
			public string GetDelivery_method(){
				return this.delivery_method_;
			}
			
			public void SetDelivery_method(string value){
				this.delivery_method_ = value;
			}
			public string GetStore_sn(){
				return this.store_sn_;
			}
			
			public void SetStore_sn(string value){
				this.store_sn_ = value;
			}
			public string GetCarrier_code(){
				return this.carrier_code_;
			}
			
			public void SetCarrier_code(string value){
				this.carrier_code_ = value;
			}
			
		}
		
		
		
		
		public class editMultiPoDelivery_args {
			
			///<summary>
			/// 供应商ID
			///</summary>
			
			private vipapis.delivery.Edit3PLMultiPoDeliveryRequest request_;
			
			public vipapis.delivery.Edit3PLMultiPoDeliveryRequest GetRequest(){
				return this.request_;
			}
			
			public void SetRequest(vipapis.delivery.Edit3PLMultiPoDeliveryRequest value){
				this.request_ = value;
			}
			
		}
		
		
		
		
		public class getDeliveryGoods_args {
			
			///<summary>
			/// 3PL运营商id
			///</summary>
			
			private int? operator_id_;
			
			///<summary>
			/// 入库单号
			///</summary>
			
			private string storage_no_;
			
			///<summary>
			/// 页码参数
			/// @sampleValue page page=1
			///</summary>
			
			private int? page_;
			
			///<summary>
			/// 返回结果数量(默认为50,最大支持100)
			/// @sampleValue limit limit=50
			///</summary>
			
			private int? limit_;
			
			public int? GetOperator_id(){
				return this.operator_id_;
			}
			
			public void SetOperator_id(int? value){
				this.operator_id_ = value;
			}
			public string GetStorage_no(){
				return this.storage_no_;
			}
			
			public void SetStorage_no(string value){
				this.storage_no_ = value;
			}
			public int? GetPage(){
				return this.page_;
			}
			
			public void SetPage(int? value){
				this.page_ = value;
			}
			public int? GetLimit(){
				return this.limit_;
			}
			
			public void SetLimit(int? value){
				this.limit_ = value;
			}
			
		}
		
		
		
		
		public class getDeliveryList_args {
			
			///<summary>
			/// 3PL运营商id
			///</summary>
			
			private int? operator_id_;
			
			///<summary>
			/// po单号
			///</summary>
			
			private string po_no_;
			
			///<summary>
			/// 运单号
			///</summary>
			
			private string delivery_no_;
			
			///<summary>
			/// 送货仓库
			/// @sampleValue warehouse warehouse=VIP_NH
			///</summary>
			
			private vipapis.common.Warehouse? warehouse_;
			
			///<summary>
			/// 送货状态(0=未出仓,1=已出仓)
			///</summary>
			
			private string out_flag_;
			
			///<summary>
			/// 送货时间(开始时间,格式'yyyy-MM-dd HH:mm:ss')
			/// @sampleValue st_out_time st_out_time=2014-07-15 10:24:45
			///</summary>
			
			private string st_out_time_;
			
			///<summary>
			/// 送货时间(结束时间,格式'yyyy-MM-dd HH:mm:ss')
			/// @sampleValue et_out_time et_out_time=2014-07-15 10:24:45
			///</summary>
			
			private string et_out_time_;
			
			///<summary>
			/// 预计到货时间(开始时间,格式'yyyy-MM-dd HH:mm:ss')
			/// @sampleValue st_estimate_arrive_time st_estimate_arrive_time=2014-07-18 10:24:45
			///</summary>
			
			private string st_estimate_arrive_time_;
			
			///<summary>
			/// 预计到货时间(结束时间,格式'yyyy-MM-dd HH:mm:ss')
			/// @sampleValue et_estimate_arrive_time et_estimate_arrive_time=2014-07-18 10:24:45
			///</summary>
			
			private string et_estimate_arrive_time_;
			
			///<summary>
			/// 实际到货时间(开始时间,格式'yyyy-MM-dd HH:mm:ss')
			/// @sampleValue st_arrive_time st_arrive_time=2014-07-17 10:24:45
			///</summary>
			
			private string st_arrive_time_;
			
			///<summary>
			/// 实际到货时间(结束时间,格式'yyyy-MM-dd HH:mm:ss')
			/// @sampleValue et_arrive_time et_arrive_time=2014-07-17 10:24:45
			///</summary>
			
			private string et_arrive_time_;
			
			///<summary>
			/// 页码参数
			/// @sampleValue page page=1
			///</summary>
			
			private int? page_;
			
			///<summary>
			/// 返回结果数量(默认为50,最大支持100)
			/// @sampleValue limit limit=50
			///</summary>
			
			private int? limit_;
			
			///<summary>
			/// 门店号
			///</summary>
			
			private string store_sn_;
			
			///<summary>
			/// 入库单号
			///</summary>
			
			private string storage_no_;
			
			public int? GetOperator_id(){
				return this.operator_id_;
			}
			
			public void SetOperator_id(int? value){
				this.operator_id_ = value;
			}
			public string GetPo_no(){
				return this.po_no_;
			}
			
			public void SetPo_no(string value){
				this.po_no_ = value;
			}
			public string GetDelivery_no(){
				return this.delivery_no_;
			}
			
			public void SetDelivery_no(string value){
				this.delivery_no_ = value;
			}
			public vipapis.common.Warehouse? GetWarehouse(){
				return this.warehouse_;
			}
			
			public void SetWarehouse(vipapis.common.Warehouse? value){
				this.warehouse_ = value;
			}
			public string GetOut_flag(){
				return this.out_flag_;
			}
			
			public void SetOut_flag(string value){
				this.out_flag_ = value;
			}
			public string GetSt_out_time(){
				return this.st_out_time_;
			}
			
			public void SetSt_out_time(string value){
				this.st_out_time_ = value;
			}
			public string GetEt_out_time(){
				return this.et_out_time_;
			}
			
			public void SetEt_out_time(string value){
				this.et_out_time_ = value;
			}
			public string GetSt_estimate_arrive_time(){
				return this.st_estimate_arrive_time_;
			}
			
			public void SetSt_estimate_arrive_time(string value){
				this.st_estimate_arrive_time_ = value;
			}
			public string GetEt_estimate_arrive_time(){
				return this.et_estimate_arrive_time_;
			}
			
			public void SetEt_estimate_arrive_time(string value){
				this.et_estimate_arrive_time_ = value;
			}
			public string GetSt_arrive_time(){
				return this.st_arrive_time_;
			}
			
			public void SetSt_arrive_time(string value){
				this.st_arrive_time_ = value;
			}
			public string GetEt_arrive_time(){
				return this.et_arrive_time_;
			}
			
			public void SetEt_arrive_time(string value){
				this.et_arrive_time_ = value;
			}
			public int? GetPage(){
				return this.page_;
			}
			
			public void SetPage(int? value){
				this.page_ = value;
			}
			public int? GetLimit(){
				return this.limit_;
			}
			
			public void SetLimit(int? value){
				this.limit_ = value;
			}
			public string GetStore_sn(){
				return this.store_sn_;
			}
			
			public void SetStore_sn(string value){
				this.store_sn_ = value;
			}
			public string GetStorage_no(){
				return this.storage_no_;
			}
			
			public void SetStorage_no(string value){
				this.storage_no_ = value;
			}
			
		}
		
		
		
		
		public class getMultiPoPickDetail_args {
			
			///<summary>
			/// 获取拣货单明细请求
			///</summary>
			
			private vipapis.delivery.Get3PLMultiPoPickDetailRequest request_;
			
			public vipapis.delivery.Get3PLMultiPoPickDetailRequest GetRequest(){
				return this.request_;
			}
			
			public void SetRequest(vipapis.delivery.Get3PLMultiPoPickDetailRequest value){
				this.request_ = value;
			}
			
		}
		
		
		
		
		public class getPickDetail_args {
			
			///<summary>
			/// po单编号
			///</summary>
			
			private string po_no_;
			
			///<summary>
			/// 3PL运营商id
			///</summary>
			
			private int? operator_id_;
			
			///<summary>
			/// 拣货单编号
			///</summary>
			
			private string pick_no_;
			
			///<summary>
			/// 页码参数
			///</summary>
			
			private int? page_;
			
			///<summary>
			/// 每页记录条数，默认50，最大100
			///</summary>
			
			private int? limit_;
			
			public string GetPo_no(){
				return this.po_no_;
			}
			
			public void SetPo_no(string value){
				this.po_no_ = value;
			}
			public int? GetOperator_id(){
				return this.operator_id_;
			}
			
			public void SetOperator_id(int? value){
				this.operator_id_ = value;
			}
			public string GetPick_no(){
				return this.pick_no_;
			}
			
			public void SetPick_no(string value){
				this.pick_no_ = value;
			}
			public int? GetPage(){
				return this.page_;
			}
			
			public void SetPage(int? value){
				this.page_ = value;
			}
			public int? GetLimit(){
				return this.limit_;
			}
			
			public void SetLimit(int? value){
				this.limit_ = value;
			}
			
		}
		
		
		
		
		public class getPickList_args {
			
			///<summary>
			/// 3PL运营商id
			///</summary>
			
			private int? operator_id_;
			
			///<summary>
			/// po订单号,支持批量，用英文逗号分隔
			///</summary>
			
			private string po_no_;
			
			///<summary>
			/// 拣货单编号
			///</summary>
			
			private string pick_no_;
			
			///<summary>
			/// 送货仓库
			///</summary>
			
			private vipapis.common.Warehouse? warehouse_;
			
			///<summary>
			/// 合作模式<br>JIT分销：jit_4a<br>普通JIT：jit
			///</summary>
			
			private string co_mode_;
			
			///<summary>
			/// 订单类别<br>normal
			///</summary>
			
			private string order_cate_;
			
			///<summary>
			/// 开始创建日期
			/// @sampleValue st_create_time 2014-07-01 10:00:00
			///</summary>
			
			private string st_create_time_;
			
			///<summary>
			/// 结束创建日期
			/// @sampleValue et_create_time 2014-07-01 10:00:00
			///</summary>
			
			private string et_create_time_;
			
			///<summary>
			/// 开始开售日期
			/// @sampleValue st_sell_time_from 2014-07-01 10:00:00
			///</summary>
			
			private string st_sell_time_from_;
			
			///<summary>
			/// 结束开售日期
			/// @sampleValue et_sell_time_from 2014-07-01 10:00:00
			///</summary>
			
			private string et_sell_time_from_;
			
			///<summary>
			/// 导出状态
			///</summary>
			
			private int? is_export_;
			
			///<summary>
			/// 页码
			/// @sampleValue page page=1
			///</summary>
			
			private int? page_;
			
			///<summary>
			/// 每页记录数(如果超过100,也只返回100条记录)
			/// @sampleValue limit limit=20
			///</summary>
			
			private int? limit_;
			
			///<summary>
			/// 门店编码
			///</summary>
			
			private string store_sn_;
			
			public int? GetOperator_id(){
				return this.operator_id_;
			}
			
			public void SetOperator_id(int? value){
				this.operator_id_ = value;
			}
			public string GetPo_no(){
				return this.po_no_;
			}
			
			public void SetPo_no(string value){
				this.po_no_ = value;
			}
			public string GetPick_no(){
				return this.pick_no_;
			}
			
			public void SetPick_no(string value){
				this.pick_no_ = value;
			}
			public vipapis.common.Warehouse? GetWarehouse(){
				return this.warehouse_;
			}
			
			public void SetWarehouse(vipapis.common.Warehouse? value){
				this.warehouse_ = value;
			}
			public string GetCo_mode(){
				return this.co_mode_;
			}
			
			public void SetCo_mode(string value){
				this.co_mode_ = value;
			}
			public string GetOrder_cate(){
				return this.order_cate_;
			}
			
			public void SetOrder_cate(string value){
				this.order_cate_ = value;
			}
			public string GetSt_create_time(){
				return this.st_create_time_;
			}
			
			public void SetSt_create_time(string value){
				this.st_create_time_ = value;
			}
			public string GetEt_create_time(){
				return this.et_create_time_;
			}
			
			public void SetEt_create_time(string value){
				this.et_create_time_ = value;
			}
			public string GetSt_sell_time_from(){
				return this.st_sell_time_from_;
			}
			
			public void SetSt_sell_time_from(string value){
				this.st_sell_time_from_ = value;
			}
			public string GetEt_sell_time_from(){
				return this.et_sell_time_from_;
			}
			
			public void SetEt_sell_time_from(string value){
				this.et_sell_time_from_ = value;
			}
			public int? GetIs_export(){
				return this.is_export_;
			}
			
			public void SetIs_export(int? value){
				this.is_export_ = value;
			}
			public int? GetPage(){
				return this.page_;
			}
			
			public void SetPage(int? value){
				this.page_ = value;
			}
			public int? GetLimit(){
				return this.limit_;
			}
			
			public void SetLimit(int? value){
				this.limit_ = value;
			}
			public string GetStore_sn(){
				return this.store_sn_;
			}
			
			public void SetStore_sn(string value){
				this.store_sn_ = value;
			}
			
		}
		
		
		
		
		public class getPoList_args {
			
			///<summary>
			/// po号
			///</summary>
			
			private string po_no_;
			
			///<summary>
			/// 合作模式,<br> JIT分销：jit_4a<br>普通JIT：jit
			///</summary>
			
			private string co_mode_;
			
			///<summary>
			/// 3PL运营商id
			/// @sampleValue operator_id 3820
			///</summary>
			
			private int? operator_id_;
			
			///<summary>
			/// 开始查询的的销售开始时间(格式为yyyy-MM-dd HH:mm:ss 开始与结束时间都为空时, 默认返回需要拣货的po)
			/// @sampleValue st_sell_st_time st_sell_st_time=2014-07-18 00:00:00
			///</summary>
			
			private string st_sell_st_time_;
			
			///<summary>
			/// 结束查询的销售开始时间(格式为yyyy-MM-dd HH:mm:ss 开始与结束时间都为空时,默认返回需要拣货的po)
			/// @sampleValue et_sell_st_time et_sell_st_time=2014-07-20 00:00:00
			///</summary>
			
			private string et_sell_st_time_;
			
			///<summary>
			/// PO开始时间开始,默认为空,格式：yyyy-MM-dd HH:mm:ss
			/// @sampleValue st_po_start_time 2014-08-18 00:00:00
			///</summary>
			
			private string st_po_start_time_;
			
			///<summary>
			/// PO开始时间结束,默认为空,格式：yyyy-MM-dd HH:mm:ss
			/// @sampleValue et_po_start_time 2014-08-18 00:00:00
			///</summary>
			
			private string et_po_start_time_;
			
			///<summary>
			/// 页码参数
			/// @sampleValue page page=1
			///</summary>
			
			private int? page_;
			
			///<summary>
			/// 返回结果数量(默认为50,最大支持100)
			/// @sampleValue limit limit=50
			///</summary>
			
			private int? limit_;
			
			public string GetPo_no(){
				return this.po_no_;
			}
			
			public void SetPo_no(string value){
				this.po_no_ = value;
			}
			public string GetCo_mode(){
				return this.co_mode_;
			}
			
			public void SetCo_mode(string value){
				this.co_mode_ = value;
			}
			public int? GetOperator_id(){
				return this.operator_id_;
			}
			
			public void SetOperator_id(int? value){
				this.operator_id_ = value;
			}
			public string GetSt_sell_st_time(){
				return this.st_sell_st_time_;
			}
			
			public void SetSt_sell_st_time(string value){
				this.st_sell_st_time_ = value;
			}
			public string GetEt_sell_st_time(){
				return this.et_sell_st_time_;
			}
			
			public void SetEt_sell_st_time(string value){
				this.et_sell_st_time_ = value;
			}
			public string GetSt_po_start_time(){
				return this.st_po_start_time_;
			}
			
			public void SetSt_po_start_time(string value){
				this.st_po_start_time_ = value;
			}
			public string GetEt_po_start_time(){
				return this.et_po_start_time_;
			}
			
			public void SetEt_po_start_time(string value){
				this.et_po_start_time_ = value;
			}
			public int? GetPage(){
				return this.page_;
			}
			
			public void SetPage(int? value){
				this.page_ = value;
			}
			public int? GetLimit(){
				return this.limit_;
			}
			
			public void SetLimit(int? value){
				this.limit_ = value;
			}
			
		}
		
		
		
		
		public class healthCheck_args {
			
			
		}
		
		
		
		
		public class importDeliveryDetail_args {
			
			///<summary>
			/// 3PL运营商id
			///</summary>
			
			private int? operator_id_;
			
			///<summary>
			/// 创建出仓单时的po单编号，多po用英文逗号隔开
			///</summary>
			
			private string po_no_;
			
			///<summary>
			/// 入库单号
			///</summary>
			
			private string storage_no_;
			
			///<summary>
			/// 门店编码，OXO业务要求填写，非OXO业务不用填写
			///</summary>
			
			private string store_sn_;
			
			///<summary>
			/// 出仓产品列表
			///</summary>
			
			private List<vipapis.delivery.Delivery> delivery_list_;
			
			public int? GetOperator_id(){
				return this.operator_id_;
			}
			
			public void SetOperator_id(int? value){
				this.operator_id_ = value;
			}
			public string GetPo_no(){
				return this.po_no_;
			}
			
			public void SetPo_no(string value){
				this.po_no_ = value;
			}
			public string GetStorage_no(){
				return this.storage_no_;
			}
			
			public void SetStorage_no(string value){
				this.storage_no_ = value;
			}
			public string GetStore_sn(){
				return this.store_sn_;
			}
			
			public void SetStore_sn(string value){
				this.store_sn_ = value;
			}
			public List<vipapis.delivery.Delivery> GetDelivery_list(){
				return this.delivery_list_;
			}
			
			public void SetDelivery_list(List<vipapis.delivery.Delivery> value){
				this.delivery_list_ = value;
			}
			
		}
		
		
		
		
		public class importMultiPoDeliveryDetail_args {
			
			///<summary>
			/// 3PL运营商id
			///</summary>
			
			private int? operator_id_;
			
			///<summary>
			/// PO单号,创建出仓单时的po单编号，可以追加po，多po用英文逗号隔开
			///</summary>
			
			private string po_no_;
			
			///<summary>
			/// 入库单号
			///</summary>
			
			private string storage_no_;
			
			///<summary>
			/// 门店编码，OXO业务要求填写，非OXO业务不用填写
			///</summary>
			
			private string store_sn_;
			
			///<summary>
			/// 出仓产品列表
			///</summary>
			
			private List<vipapis.delivery.Delivery> delivery_list_;
			
			public int? GetOperator_id(){
				return this.operator_id_;
			}
			
			public void SetOperator_id(int? value){
				this.operator_id_ = value;
			}
			public string GetPo_no(){
				return this.po_no_;
			}
			
			public void SetPo_no(string value){
				this.po_no_ = value;
			}
			public string GetStorage_no(){
				return this.storage_no_;
			}
			
			public void SetStorage_no(string value){
				this.storage_no_ = value;
			}
			public string GetStore_sn(){
				return this.store_sn_;
			}
			
			public void SetStore_sn(string value){
				this.store_sn_ = value;
			}
			public List<vipapis.delivery.Delivery> GetDelivery_list(){
				return this.delivery_list_;
			}
			
			public void SetDelivery_list(List<vipapis.delivery.Delivery> value){
				this.delivery_list_ = value;
			}
			
		}
		
		
		
		
		public class confirmDelivery_result {
			
			///<summary>
			/// 返回影响记录的行数,通常返回为：1, (对于海淘jit会返回批次号)
			///</summary>
			
			private string success_;
			
			public string GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(string value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class createDelivery_result {
			
			///<summary>
			///</summary>
			
			private vipapis.delivery.CreateDeliveryResponse success_;
			
			public vipapis.delivery.CreateDeliveryResponse GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(vipapis.delivery.CreateDeliveryResponse value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class createMultiPoDelivery_result {
			
			///<summary>
			/// 出仓单编号
			///</summary>
			
			private string success_;
			
			public string GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(string value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class createPick_result {
			
			///<summary>
			///</summary>
			
			private List<vipapis.delivery.SimplePick> success_;
			
			public List<vipapis.delivery.SimplePick> GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(List<vipapis.delivery.SimplePick> value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class deleteDeliveryDetail_result {
			
			///<summary>
			///</summary>
			
			private List<vipapis.delivery.DeleteDeliveryDetail> success_;
			
			public List<vipapis.delivery.DeleteDeliveryDetail> GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(List<vipapis.delivery.DeleteDeliveryDetail> value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class editDelivery_result {
			
			///<summary>
			/// 返回影响记录的行数,通常返回为：1
			///</summary>
			
			private string success_;
			
			public string GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(string value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class editMultiPoDelivery_result {
			
			///<summary>
			/// 修改成功：true，如果失败会返回异常信息
			///</summary>
			
			private bool? success_;
			
			public bool? GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(bool? value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class getDeliveryGoods_result {
			
			///<summary>
			///</summary>
			
			private vipapis.delivery.GetDeliveryGoodsResponse success_;
			
			public vipapis.delivery.GetDeliveryGoodsResponse GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(vipapis.delivery.GetDeliveryGoodsResponse value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class getDeliveryList_result {
			
			///<summary>
			///</summary>
			
			private vipapis.delivery.GetDeliveryListResponse success_;
			
			public vipapis.delivery.GetDeliveryListResponse GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(vipapis.delivery.GetDeliveryListResponse value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class getMultiPoPickDetail_result {
			
			///<summary>
			///</summary>
			
			private vipapis.delivery.GetMultiPoPickDetailResponse success_;
			
			public vipapis.delivery.GetMultiPoPickDetailResponse GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(vipapis.delivery.GetMultiPoPickDetailResponse value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class getPickDetail_result {
			
			///<summary>
			///</summary>
			
			private vipapis.delivery.PickDetail success_;
			
			public vipapis.delivery.PickDetail GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(vipapis.delivery.PickDetail value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class getPickList_result {
			
			///<summary>
			///</summary>
			
			private vipapis.delivery.GetPickListResponse success_;
			
			public vipapis.delivery.GetPickListResponse GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(vipapis.delivery.GetPickListResponse value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class getPoList_result {
			
			///<summary>
			///</summary>
			
			private vipapis.delivery.Get3PLPoListResponse success_;
			
			public vipapis.delivery.Get3PLPoListResponse GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(vipapis.delivery.Get3PLPoListResponse value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class healthCheck_result {
			
			///<summary>
			///</summary>
			
			private com.vip.hermes.core.health.CheckResult success_;
			
			public com.vip.hermes.core.health.CheckResult GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(com.vip.hermes.core.health.CheckResult value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class importDeliveryDetail_result {
			
			///<summary>
			/// 返回成功信息，没有抛异常即为成功
			///</summary>
			
			private string success_;
			
			public string GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(string value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class importMultiPoDeliveryDetail_result {
			
			///<summary>
			/// 返回成功信息，没有抛异常即为成功
			///</summary>
			
			private string success_;
			
			public string GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(string value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		
		public class confirmDelivery_argsHelper : TBeanSerializer<confirmDelivery_args>
		{
			
			public static confirmDelivery_argsHelper OBJ = new confirmDelivery_argsHelper();
			
			public static confirmDelivery_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(confirmDelivery_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					int value;
					value = iprot.ReadI32(); 
					
					structs.SetOperator_id(value);
				}
				
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetStorage_no(value);
				}
				
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetStore_sn(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(confirmDelivery_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetOperator_id() != null) {
					
					oprot.WriteFieldBegin("operator_id");
					oprot.WriteI32((int)structs.GetOperator_id()); 
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("operator_id can not be null!");
				}
				
				
				if(structs.GetStorage_no() != null) {
					
					oprot.WriteFieldBegin("storage_no");
					oprot.WriteString(structs.GetStorage_no());
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("storage_no can not be null!");
				}
				
				
				if(structs.GetStore_sn() != null) {
					
					oprot.WriteFieldBegin("store_sn");
					oprot.WriteString(structs.GetStore_sn());
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(confirmDelivery_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class createDelivery_argsHelper : TBeanSerializer<createDelivery_args>
		{
			
			public static createDelivery_argsHelper OBJ = new createDelivery_argsHelper();
			
			public static createDelivery_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(createDelivery_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					int value;
					value = iprot.ReadI32(); 
					
					structs.SetOperator_id(value);
				}
				
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetPo_no(value);
				}
				
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetDelivery_no(value);
				}
				
				
				
				
				
				if(true){
					
					vipapis.common.Warehouse? value;
					
					value = vipapis.common.WarehouseUtil.FindByName(iprot.ReadString());
					
					structs.SetWarehouse(value);
				}
				
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetDelivery_time(value);
				}
				
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetArrival_time(value);
				}
				
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetCarrier_name(value);
				}
				
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetDelivery_method(value);
				}
				
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetStore_sn(value);
				}
				
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetCarrier_code(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(createDelivery_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetOperator_id() != null) {
					
					oprot.WriteFieldBegin("operator_id");
					oprot.WriteI32((int)structs.GetOperator_id()); 
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("operator_id can not be null!");
				}
				
				
				if(structs.GetPo_no() != null) {
					
					oprot.WriteFieldBegin("po_no");
					oprot.WriteString(structs.GetPo_no());
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("po_no can not be null!");
				}
				
				
				if(structs.GetDelivery_no() != null) {
					
					oprot.WriteFieldBegin("delivery_no");
					oprot.WriteString(structs.GetDelivery_no());
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("delivery_no can not be null!");
				}
				
				
				if(structs.GetWarehouse() != null) {
					
					oprot.WriteFieldBegin("warehouse");
					oprot.WriteString(structs.GetWarehouse().ToString());  
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("warehouse can not be null!");
				}
				
				
				if(structs.GetDelivery_time() != null) {
					
					oprot.WriteFieldBegin("delivery_time");
					oprot.WriteString(structs.GetDelivery_time());
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetArrival_time() != null) {
					
					oprot.WriteFieldBegin("arrival_time");
					oprot.WriteString(structs.GetArrival_time());
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("arrival_time can not be null!");
				}
				
				
				if(structs.GetCarrier_name() != null) {
					
					oprot.WriteFieldBegin("carrier_name");
					oprot.WriteString(structs.GetCarrier_name());
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("carrier_name can not be null!");
				}
				
				
				if(structs.GetDelivery_method() != null) {
					
					oprot.WriteFieldBegin("delivery_method");
					oprot.WriteString(structs.GetDelivery_method());
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetStore_sn() != null) {
					
					oprot.WriteFieldBegin("store_sn");
					oprot.WriteString(structs.GetStore_sn());
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetCarrier_code() != null) {
					
					oprot.WriteFieldBegin("carrier_code");
					oprot.WriteString(structs.GetCarrier_code());
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("carrier_code can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(createDelivery_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class createMultiPoDelivery_argsHelper : TBeanSerializer<createMultiPoDelivery_args>
		{
			
			public static createMultiPoDelivery_argsHelper OBJ = new createMultiPoDelivery_argsHelper();
			
			public static createMultiPoDelivery_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(createMultiPoDelivery_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					vipapis.delivery.Create3PLMultiPoDeliveryRequest value;
					
					value = new vipapis.delivery.Create3PLMultiPoDeliveryRequest();
					vipapis.delivery.Create3PLMultiPoDeliveryRequestHelper.getInstance().Read(value, iprot);
					
					structs.SetRequest(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(createMultiPoDelivery_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetRequest() != null) {
					
					oprot.WriteFieldBegin("request");
					
					vipapis.delivery.Create3PLMultiPoDeliveryRequestHelper.getInstance().Write(structs.GetRequest(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("request can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(createMultiPoDelivery_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class createPick_argsHelper : TBeanSerializer<createPick_args>
		{
			
			public static createPick_argsHelper OBJ = new createPick_argsHelper();
			
			public static createPick_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(createPick_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetPo_no(value);
				}
				
				
				
				
				
				if(true){
					
					int value;
					value = iprot.ReadI32(); 
					
					structs.SetOperator_id(value);
				}
				
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetWarehouse(value);
				}
				
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetStore_sn(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(createPick_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetPo_no() != null) {
					
					oprot.WriteFieldBegin("po_no");
					oprot.WriteString(structs.GetPo_no());
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("po_no can not be null!");
				}
				
				
				if(structs.GetOperator_id() != null) {
					
					oprot.WriteFieldBegin("operator_id");
					oprot.WriteI32((int)structs.GetOperator_id()); 
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("operator_id can not be null!");
				}
				
				
				if(structs.GetWarehouse() != null) {
					
					oprot.WriteFieldBegin("warehouse");
					oprot.WriteString(structs.GetWarehouse());
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetStore_sn() != null) {
					
					oprot.WriteFieldBegin("store_sn");
					oprot.WriteString(structs.GetStore_sn());
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(createPick_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class deleteDeliveryDetail_argsHelper : TBeanSerializer<deleteDeliveryDetail_args>
		{
			
			public static deleteDeliveryDetail_argsHelper OBJ = new deleteDeliveryDetail_argsHelper();
			
			public static deleteDeliveryDetail_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(deleteDeliveryDetail_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					int value;
					value = iprot.ReadI32(); 
					
					structs.SetOperator_id(value);
				}
				
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetStorage_no(value);
				}
				
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetPo_no(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(deleteDeliveryDetail_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetOperator_id() != null) {
					
					oprot.WriteFieldBegin("operator_id");
					oprot.WriteI32((int)structs.GetOperator_id()); 
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("operator_id can not be null!");
				}
				
				
				if(structs.GetStorage_no() != null) {
					
					oprot.WriteFieldBegin("storage_no");
					oprot.WriteString(structs.GetStorage_no());
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("storage_no can not be null!");
				}
				
				
				if(structs.GetPo_no() != null) {
					
					oprot.WriteFieldBegin("po_no");
					oprot.WriteString(structs.GetPo_no());
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(deleteDeliveryDetail_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class editDelivery_argsHelper : TBeanSerializer<editDelivery_args>
		{
			
			public static editDelivery_argsHelper OBJ = new editDelivery_argsHelper();
			
			public static editDelivery_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(editDelivery_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					int value;
					value = iprot.ReadI32(); 
					
					structs.SetOperator_id(value);
				}
				
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetStorage_no(value);
				}
				
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetDelivery_no(value);
				}
				
				
				
				
				
				if(true){
					
					vipapis.common.Warehouse? value;
					
					value = vipapis.common.WarehouseUtil.FindByName(iprot.ReadString());
					
					structs.SetWarehouse(value);
				}
				
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetDelivery_time(value);
				}
				
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetArrival_time(value);
				}
				
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetCarrier_name(value);
				}
				
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetTel(value);
				}
				
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetDriver(value);
				}
				
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetDriver_tel(value);
				}
				
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetDelivery_method(value);
				}
				
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetStore_sn(value);
				}
				
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetCarrier_code(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(editDelivery_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetOperator_id() != null) {
					
					oprot.WriteFieldBegin("operator_id");
					oprot.WriteI32((int)structs.GetOperator_id()); 
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("operator_id can not be null!");
				}
				
				
				if(structs.GetStorage_no() != null) {
					
					oprot.WriteFieldBegin("storage_no");
					oprot.WriteString(structs.GetStorage_no());
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("storage_no can not be null!");
				}
				
				
				if(structs.GetDelivery_no() != null) {
					
					oprot.WriteFieldBegin("delivery_no");
					oprot.WriteString(structs.GetDelivery_no());
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetWarehouse() != null) {
					
					oprot.WriteFieldBegin("warehouse");
					oprot.WriteString(structs.GetWarehouse().ToString());  
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("warehouse can not be null!");
				}
				
				
				if(structs.GetDelivery_time() != null) {
					
					oprot.WriteFieldBegin("delivery_time");
					oprot.WriteString(structs.GetDelivery_time());
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("delivery_time can not be null!");
				}
				
				
				if(structs.GetArrival_time() != null) {
					
					oprot.WriteFieldBegin("arrival_time");
					oprot.WriteString(structs.GetArrival_time());
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetCarrier_name() != null) {
					
					oprot.WriteFieldBegin("carrier_name");
					oprot.WriteString(structs.GetCarrier_name());
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetTel() != null) {
					
					oprot.WriteFieldBegin("tel");
					oprot.WriteString(structs.GetTel());
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetDriver() != null) {
					
					oprot.WriteFieldBegin("driver");
					oprot.WriteString(structs.GetDriver());
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetDriver_tel() != null) {
					
					oprot.WriteFieldBegin("driver_tel");
					oprot.WriteString(structs.GetDriver_tel());
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetDelivery_method() != null) {
					
					oprot.WriteFieldBegin("delivery_method");
					oprot.WriteString(structs.GetDelivery_method());
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetStore_sn() != null) {
					
					oprot.WriteFieldBegin("store_sn");
					oprot.WriteString(structs.GetStore_sn());
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetCarrier_code() != null) {
					
					oprot.WriteFieldBegin("carrier_code");
					oprot.WriteString(structs.GetCarrier_code());
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(editDelivery_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class editMultiPoDelivery_argsHelper : TBeanSerializer<editMultiPoDelivery_args>
		{
			
			public static editMultiPoDelivery_argsHelper OBJ = new editMultiPoDelivery_argsHelper();
			
			public static editMultiPoDelivery_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(editMultiPoDelivery_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					vipapis.delivery.Edit3PLMultiPoDeliveryRequest value;
					
					value = new vipapis.delivery.Edit3PLMultiPoDeliveryRequest();
					vipapis.delivery.Edit3PLMultiPoDeliveryRequestHelper.getInstance().Read(value, iprot);
					
					structs.SetRequest(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(editMultiPoDelivery_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetRequest() != null) {
					
					oprot.WriteFieldBegin("request");
					
					vipapis.delivery.Edit3PLMultiPoDeliveryRequestHelper.getInstance().Write(structs.GetRequest(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("request can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(editMultiPoDelivery_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getDeliveryGoods_argsHelper : TBeanSerializer<getDeliveryGoods_args>
		{
			
			public static getDeliveryGoods_argsHelper OBJ = new getDeliveryGoods_argsHelper();
			
			public static getDeliveryGoods_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getDeliveryGoods_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					int value;
					value = iprot.ReadI32(); 
					
					structs.SetOperator_id(value);
				}
				
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetStorage_no(value);
				}
				
				
				
				
				
				if(true){
					
					int? value;
					value = iprot.ReadI32(); 
					
					structs.SetPage(value);
				}
				
				
				
				
				
				if(true){
					
					int? value;
					value = iprot.ReadI32(); 
					
					structs.SetLimit(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getDeliveryGoods_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetOperator_id() != null) {
					
					oprot.WriteFieldBegin("operator_id");
					oprot.WriteI32((int)structs.GetOperator_id()); 
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("operator_id can not be null!");
				}
				
				
				if(structs.GetStorage_no() != null) {
					
					oprot.WriteFieldBegin("storage_no");
					oprot.WriteString(structs.GetStorage_no());
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("storage_no can not be null!");
				}
				
				
				if(structs.GetPage() != null) {
					
					oprot.WriteFieldBegin("page");
					oprot.WriteI32((int)structs.GetPage()); 
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetLimit() != null) {
					
					oprot.WriteFieldBegin("limit");
					oprot.WriteI32((int)structs.GetLimit()); 
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getDeliveryGoods_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getDeliveryList_argsHelper : TBeanSerializer<getDeliveryList_args>
		{
			
			public static getDeliveryList_argsHelper OBJ = new getDeliveryList_argsHelper();
			
			public static getDeliveryList_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getDeliveryList_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					int value;
					value = iprot.ReadI32(); 
					
					structs.SetOperator_id(value);
				}
				
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetPo_no(value);
				}
				
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetDelivery_no(value);
				}
				
				
				
				
				
				if(true){
					
					vipapis.common.Warehouse? value;
					
					value = vipapis.common.WarehouseUtil.FindByName(iprot.ReadString());
					
					structs.SetWarehouse(value);
				}
				
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetOut_flag(value);
				}
				
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetSt_out_time(value);
				}
				
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetEt_out_time(value);
				}
				
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetSt_estimate_arrive_time(value);
				}
				
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetEt_estimate_arrive_time(value);
				}
				
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetSt_arrive_time(value);
				}
				
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetEt_arrive_time(value);
				}
				
				
				
				
				
				if(true){
					
					int? value;
					value = iprot.ReadI32(); 
					
					structs.SetPage(value);
				}
				
				
				
				
				
				if(true){
					
					int? value;
					value = iprot.ReadI32(); 
					
					structs.SetLimit(value);
				}
				
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetStore_sn(value);
				}
				
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetStorage_no(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getDeliveryList_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetOperator_id() != null) {
					
					oprot.WriteFieldBegin("operator_id");
					oprot.WriteI32((int)structs.GetOperator_id()); 
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("operator_id can not be null!");
				}
				
				
				if(structs.GetPo_no() != null) {
					
					oprot.WriteFieldBegin("po_no");
					oprot.WriteString(structs.GetPo_no());
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetDelivery_no() != null) {
					
					oprot.WriteFieldBegin("delivery_no");
					oprot.WriteString(structs.GetDelivery_no());
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetWarehouse() != null) {
					
					oprot.WriteFieldBegin("warehouse");
					oprot.WriteString(structs.GetWarehouse().ToString());  
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetOut_flag() != null) {
					
					oprot.WriteFieldBegin("out_flag");
					oprot.WriteString(structs.GetOut_flag());
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetSt_out_time() != null) {
					
					oprot.WriteFieldBegin("st_out_time");
					oprot.WriteString(structs.GetSt_out_time());
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetEt_out_time() != null) {
					
					oprot.WriteFieldBegin("et_out_time");
					oprot.WriteString(structs.GetEt_out_time());
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetSt_estimate_arrive_time() != null) {
					
					oprot.WriteFieldBegin("st_estimate_arrive_time");
					oprot.WriteString(structs.GetSt_estimate_arrive_time());
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetEt_estimate_arrive_time() != null) {
					
					oprot.WriteFieldBegin("et_estimate_arrive_time");
					oprot.WriteString(structs.GetEt_estimate_arrive_time());
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetSt_arrive_time() != null) {
					
					oprot.WriteFieldBegin("st_arrive_time");
					oprot.WriteString(structs.GetSt_arrive_time());
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetEt_arrive_time() != null) {
					
					oprot.WriteFieldBegin("et_arrive_time");
					oprot.WriteString(structs.GetEt_arrive_time());
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetPage() != null) {
					
					oprot.WriteFieldBegin("page");
					oprot.WriteI32((int)structs.GetPage()); 
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetLimit() != null) {
					
					oprot.WriteFieldBegin("limit");
					oprot.WriteI32((int)structs.GetLimit()); 
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetStore_sn() != null) {
					
					oprot.WriteFieldBegin("store_sn");
					oprot.WriteString(structs.GetStore_sn());
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetStorage_no() != null) {
					
					oprot.WriteFieldBegin("storage_no");
					oprot.WriteString(structs.GetStorage_no());
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getDeliveryList_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getMultiPoPickDetail_argsHelper : TBeanSerializer<getMultiPoPickDetail_args>
		{
			
			public static getMultiPoPickDetail_argsHelper OBJ = new getMultiPoPickDetail_argsHelper();
			
			public static getMultiPoPickDetail_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getMultiPoPickDetail_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					vipapis.delivery.Get3PLMultiPoPickDetailRequest value;
					
					value = new vipapis.delivery.Get3PLMultiPoPickDetailRequest();
					vipapis.delivery.Get3PLMultiPoPickDetailRequestHelper.getInstance().Read(value, iprot);
					
					structs.SetRequest(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getMultiPoPickDetail_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetRequest() != null) {
					
					oprot.WriteFieldBegin("request");
					
					vipapis.delivery.Get3PLMultiPoPickDetailRequestHelper.getInstance().Write(structs.GetRequest(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("request can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getMultiPoPickDetail_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getPickDetail_argsHelper : TBeanSerializer<getPickDetail_args>
		{
			
			public static getPickDetail_argsHelper OBJ = new getPickDetail_argsHelper();
			
			public static getPickDetail_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getPickDetail_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetPo_no(value);
				}
				
				
				
				
				
				if(true){
					
					int value;
					value = iprot.ReadI32(); 
					
					structs.SetOperator_id(value);
				}
				
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetPick_no(value);
				}
				
				
				
				
				
				if(true){
					
					int? value;
					value = iprot.ReadI32(); 
					
					structs.SetPage(value);
				}
				
				
				
				
				
				if(true){
					
					int? value;
					value = iprot.ReadI32(); 
					
					structs.SetLimit(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getPickDetail_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetPo_no() != null) {
					
					oprot.WriteFieldBegin("po_no");
					oprot.WriteString(structs.GetPo_no());
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("po_no can not be null!");
				}
				
				
				if(structs.GetOperator_id() != null) {
					
					oprot.WriteFieldBegin("operator_id");
					oprot.WriteI32((int)structs.GetOperator_id()); 
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("operator_id can not be null!");
				}
				
				
				if(structs.GetPick_no() != null) {
					
					oprot.WriteFieldBegin("pick_no");
					oprot.WriteString(structs.GetPick_no());
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("pick_no can not be null!");
				}
				
				
				if(structs.GetPage() != null) {
					
					oprot.WriteFieldBegin("page");
					oprot.WriteI32((int)structs.GetPage()); 
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetLimit() != null) {
					
					oprot.WriteFieldBegin("limit");
					oprot.WriteI32((int)structs.GetLimit()); 
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getPickDetail_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getPickList_argsHelper : TBeanSerializer<getPickList_args>
		{
			
			public static getPickList_argsHelper OBJ = new getPickList_argsHelper();
			
			public static getPickList_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getPickList_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					int value;
					value = iprot.ReadI32(); 
					
					structs.SetOperator_id(value);
				}
				
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetPo_no(value);
				}
				
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetPick_no(value);
				}
				
				
				
				
				
				if(true){
					
					vipapis.common.Warehouse? value;
					
					value = vipapis.common.WarehouseUtil.FindByName(iprot.ReadString());
					
					structs.SetWarehouse(value);
				}
				
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetCo_mode(value);
				}
				
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetOrder_cate(value);
				}
				
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetSt_create_time(value);
				}
				
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetEt_create_time(value);
				}
				
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetSt_sell_time_from(value);
				}
				
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetEt_sell_time_from(value);
				}
				
				
				
				
				
				if(true){
					
					int? value;
					value = iprot.ReadI32(); 
					
					structs.SetIs_export(value);
				}
				
				
				
				
				
				if(true){
					
					int? value;
					value = iprot.ReadI32(); 
					
					structs.SetPage(value);
				}
				
				
				
				
				
				if(true){
					
					int? value;
					value = iprot.ReadI32(); 
					
					structs.SetLimit(value);
				}
				
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetStore_sn(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getPickList_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetOperator_id() != null) {
					
					oprot.WriteFieldBegin("operator_id");
					oprot.WriteI32((int)structs.GetOperator_id()); 
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("operator_id can not be null!");
				}
				
				
				if(structs.GetPo_no() != null) {
					
					oprot.WriteFieldBegin("po_no");
					oprot.WriteString(structs.GetPo_no());
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetPick_no() != null) {
					
					oprot.WriteFieldBegin("pick_no");
					oprot.WriteString(structs.GetPick_no());
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetWarehouse() != null) {
					
					oprot.WriteFieldBegin("warehouse");
					oprot.WriteString(structs.GetWarehouse().ToString());  
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetCo_mode() != null) {
					
					oprot.WriteFieldBegin("co_mode");
					oprot.WriteString(structs.GetCo_mode());
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetOrder_cate() != null) {
					
					oprot.WriteFieldBegin("order_cate");
					oprot.WriteString(structs.GetOrder_cate());
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetSt_create_time() != null) {
					
					oprot.WriteFieldBegin("st_create_time");
					oprot.WriteString(structs.GetSt_create_time());
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetEt_create_time() != null) {
					
					oprot.WriteFieldBegin("et_create_time");
					oprot.WriteString(structs.GetEt_create_time());
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetSt_sell_time_from() != null) {
					
					oprot.WriteFieldBegin("st_sell_time_from");
					oprot.WriteString(structs.GetSt_sell_time_from());
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetEt_sell_time_from() != null) {
					
					oprot.WriteFieldBegin("et_sell_time_from");
					oprot.WriteString(structs.GetEt_sell_time_from());
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetIs_export() != null) {
					
					oprot.WriteFieldBegin("is_export");
					oprot.WriteI32((int)structs.GetIs_export()); 
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetPage() != null) {
					
					oprot.WriteFieldBegin("page");
					oprot.WriteI32((int)structs.GetPage()); 
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetLimit() != null) {
					
					oprot.WriteFieldBegin("limit");
					oprot.WriteI32((int)structs.GetLimit()); 
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetStore_sn() != null) {
					
					oprot.WriteFieldBegin("store_sn");
					oprot.WriteString(structs.GetStore_sn());
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getPickList_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getPoList_argsHelper : TBeanSerializer<getPoList_args>
		{
			
			public static getPoList_argsHelper OBJ = new getPoList_argsHelper();
			
			public static getPoList_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getPoList_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetPo_no(value);
				}
				
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetCo_mode(value);
				}
				
				
				
				
				
				if(true){
					
					int value;
					value = iprot.ReadI32(); 
					
					structs.SetOperator_id(value);
				}
				
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetSt_sell_st_time(value);
				}
				
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetEt_sell_st_time(value);
				}
				
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetSt_po_start_time(value);
				}
				
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetEt_po_start_time(value);
				}
				
				
				
				
				
				if(true){
					
					int? value;
					value = iprot.ReadI32(); 
					
					structs.SetPage(value);
				}
				
				
				
				
				
				if(true){
					
					int? value;
					value = iprot.ReadI32(); 
					
					structs.SetLimit(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getPoList_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetPo_no() != null) {
					
					oprot.WriteFieldBegin("po_no");
					oprot.WriteString(structs.GetPo_no());
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetCo_mode() != null) {
					
					oprot.WriteFieldBegin("co_mode");
					oprot.WriteString(structs.GetCo_mode());
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetOperator_id() != null) {
					
					oprot.WriteFieldBegin("operator_id");
					oprot.WriteI32((int)structs.GetOperator_id()); 
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("operator_id can not be null!");
				}
				
				
				if(structs.GetSt_sell_st_time() != null) {
					
					oprot.WriteFieldBegin("st_sell_st_time");
					oprot.WriteString(structs.GetSt_sell_st_time());
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetEt_sell_st_time() != null) {
					
					oprot.WriteFieldBegin("et_sell_st_time");
					oprot.WriteString(structs.GetEt_sell_st_time());
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetSt_po_start_time() != null) {
					
					oprot.WriteFieldBegin("st_po_start_time");
					oprot.WriteString(structs.GetSt_po_start_time());
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetEt_po_start_time() != null) {
					
					oprot.WriteFieldBegin("et_po_start_time");
					oprot.WriteString(structs.GetEt_po_start_time());
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetPage() != null) {
					
					oprot.WriteFieldBegin("page");
					oprot.WriteI32((int)structs.GetPage()); 
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetLimit() != null) {
					
					oprot.WriteFieldBegin("limit");
					oprot.WriteI32((int)structs.GetLimit()); 
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getPoList_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class healthCheck_argsHelper : TBeanSerializer<healthCheck_args>
		{
			
			public static healthCheck_argsHelper OBJ = new healthCheck_argsHelper();
			
			public static healthCheck_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(healthCheck_args structs, Protocol iprot){
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(healthCheck_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(healthCheck_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class importDeliveryDetail_argsHelper : TBeanSerializer<importDeliveryDetail_args>
		{
			
			public static importDeliveryDetail_argsHelper OBJ = new importDeliveryDetail_argsHelper();
			
			public static importDeliveryDetail_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(importDeliveryDetail_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					int value;
					value = iprot.ReadI32(); 
					
					structs.SetOperator_id(value);
				}
				
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetPo_no(value);
				}
				
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetStorage_no(value);
				}
				
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetStore_sn(value);
				}
				
				
				
				
				
				if(true){
					
					List<vipapis.delivery.Delivery> value;
					
					value = new List<vipapis.delivery.Delivery>();
					iprot.ReadListBegin();
					while(true){
						
						try{
							
							vipapis.delivery.Delivery elem0;
							
							elem0 = new vipapis.delivery.Delivery();
							vipapis.delivery.DeliveryHelper.getInstance().Read(elem0, iprot);
							
							value.Add(elem0);
						}
						catch(Exception e){
							
							
							break;
						}
					}
					
					iprot.ReadListEnd();
					
					structs.SetDelivery_list(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(importDeliveryDetail_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetOperator_id() != null) {
					
					oprot.WriteFieldBegin("operator_id");
					oprot.WriteI32((int)structs.GetOperator_id()); 
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("operator_id can not be null!");
				}
				
				
				if(structs.GetPo_no() != null) {
					
					oprot.WriteFieldBegin("po_no");
					oprot.WriteString(structs.GetPo_no());
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("po_no can not be null!");
				}
				
				
				if(structs.GetStorage_no() != null) {
					
					oprot.WriteFieldBegin("storage_no");
					oprot.WriteString(structs.GetStorage_no());
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("storage_no can not be null!");
				}
				
				
				if(structs.GetStore_sn() != null) {
					
					oprot.WriteFieldBegin("store_sn");
					oprot.WriteString(structs.GetStore_sn());
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetDelivery_list() != null) {
					
					oprot.WriteFieldBegin("delivery_list");
					
					oprot.WriteListBegin();
					foreach(vipapis.delivery.Delivery _item0 in structs.GetDelivery_list()){
						
						
						vipapis.delivery.DeliveryHelper.getInstance().Write(_item0, oprot);
						
					}
					
					oprot.WriteListEnd();
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("delivery_list can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(importDeliveryDetail_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class importMultiPoDeliveryDetail_argsHelper : TBeanSerializer<importMultiPoDeliveryDetail_args>
		{
			
			public static importMultiPoDeliveryDetail_argsHelper OBJ = new importMultiPoDeliveryDetail_argsHelper();
			
			public static importMultiPoDeliveryDetail_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(importMultiPoDeliveryDetail_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					int value;
					value = iprot.ReadI32(); 
					
					structs.SetOperator_id(value);
				}
				
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetPo_no(value);
				}
				
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetStorage_no(value);
				}
				
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetStore_sn(value);
				}
				
				
				
				
				
				if(true){
					
					List<vipapis.delivery.Delivery> value;
					
					value = new List<vipapis.delivery.Delivery>();
					iprot.ReadListBegin();
					while(true){
						
						try{
							
							vipapis.delivery.Delivery elem1;
							
							elem1 = new vipapis.delivery.Delivery();
							vipapis.delivery.DeliveryHelper.getInstance().Read(elem1, iprot);
							
							value.Add(elem1);
						}
						catch(Exception e){
							
							
							break;
						}
					}
					
					iprot.ReadListEnd();
					
					structs.SetDelivery_list(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(importMultiPoDeliveryDetail_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetOperator_id() != null) {
					
					oprot.WriteFieldBegin("operator_id");
					oprot.WriteI32((int)structs.GetOperator_id()); 
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("operator_id can not be null!");
				}
				
				
				if(structs.GetPo_no() != null) {
					
					oprot.WriteFieldBegin("po_no");
					oprot.WriteString(structs.GetPo_no());
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("po_no can not be null!");
				}
				
				
				if(structs.GetStorage_no() != null) {
					
					oprot.WriteFieldBegin("storage_no");
					oprot.WriteString(structs.GetStorage_no());
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("storage_no can not be null!");
				}
				
				
				if(structs.GetStore_sn() != null) {
					
					oprot.WriteFieldBegin("store_sn");
					oprot.WriteString(structs.GetStore_sn());
					
					oprot.WriteFieldEnd();
				}
				
				
				if(structs.GetDelivery_list() != null) {
					
					oprot.WriteFieldBegin("delivery_list");
					
					oprot.WriteListBegin();
					foreach(vipapis.delivery.Delivery _item0 in structs.GetDelivery_list()){
						
						
						vipapis.delivery.DeliveryHelper.getInstance().Write(_item0, oprot);
						
					}
					
					oprot.WriteListEnd();
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("delivery_list can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(importMultiPoDeliveryDetail_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class confirmDelivery_resultHelper : TBeanSerializer<confirmDelivery_result>
		{
			
			public static confirmDelivery_resultHelper OBJ = new confirmDelivery_resultHelper();
			
			public static confirmDelivery_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(confirmDelivery_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(confirmDelivery_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					oprot.WriteString(structs.GetSuccess());
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(confirmDelivery_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class createDelivery_resultHelper : TBeanSerializer<createDelivery_result>
		{
			
			public static createDelivery_resultHelper OBJ = new createDelivery_resultHelper();
			
			public static createDelivery_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(createDelivery_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					vipapis.delivery.CreateDeliveryResponse value;
					
					value = new vipapis.delivery.CreateDeliveryResponse();
					vipapis.delivery.CreateDeliveryResponseHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(createDelivery_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					vipapis.delivery.CreateDeliveryResponseHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(createDelivery_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class createMultiPoDelivery_resultHelper : TBeanSerializer<createMultiPoDelivery_result>
		{
			
			public static createMultiPoDelivery_resultHelper OBJ = new createMultiPoDelivery_resultHelper();
			
			public static createMultiPoDelivery_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(createMultiPoDelivery_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(createMultiPoDelivery_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					oprot.WriteString(structs.GetSuccess());
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(createMultiPoDelivery_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class createPick_resultHelper : TBeanSerializer<createPick_result>
		{
			
			public static createPick_resultHelper OBJ = new createPick_resultHelper();
			
			public static createPick_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(createPick_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					List<vipapis.delivery.SimplePick> value;
					
					value = new List<vipapis.delivery.SimplePick>();
					iprot.ReadListBegin();
					while(true){
						
						try{
							
							vipapis.delivery.SimplePick elem0;
							
							elem0 = new vipapis.delivery.SimplePick();
							vipapis.delivery.SimplePickHelper.getInstance().Read(elem0, iprot);
							
							value.Add(elem0);
						}
						catch(Exception e){
							
							
							break;
						}
					}
					
					iprot.ReadListEnd();
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(createPick_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					oprot.WriteListBegin();
					foreach(vipapis.delivery.SimplePick _item0 in structs.GetSuccess()){
						
						
						vipapis.delivery.SimplePickHelper.getInstance().Write(_item0, oprot);
						
					}
					
					oprot.WriteListEnd();
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(createPick_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class deleteDeliveryDetail_resultHelper : TBeanSerializer<deleteDeliveryDetail_result>
		{
			
			public static deleteDeliveryDetail_resultHelper OBJ = new deleteDeliveryDetail_resultHelper();
			
			public static deleteDeliveryDetail_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(deleteDeliveryDetail_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					List<vipapis.delivery.DeleteDeliveryDetail> value;
					
					value = new List<vipapis.delivery.DeleteDeliveryDetail>();
					iprot.ReadListBegin();
					while(true){
						
						try{
							
							vipapis.delivery.DeleteDeliveryDetail elem1;
							
							elem1 = new vipapis.delivery.DeleteDeliveryDetail();
							vipapis.delivery.DeleteDeliveryDetailHelper.getInstance().Read(elem1, iprot);
							
							value.Add(elem1);
						}
						catch(Exception e){
							
							
							break;
						}
					}
					
					iprot.ReadListEnd();
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(deleteDeliveryDetail_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					oprot.WriteListBegin();
					foreach(vipapis.delivery.DeleteDeliveryDetail _item0 in structs.GetSuccess()){
						
						
						vipapis.delivery.DeleteDeliveryDetailHelper.getInstance().Write(_item0, oprot);
						
					}
					
					oprot.WriteListEnd();
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(deleteDeliveryDetail_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class editDelivery_resultHelper : TBeanSerializer<editDelivery_result>
		{
			
			public static editDelivery_resultHelper OBJ = new editDelivery_resultHelper();
			
			public static editDelivery_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(editDelivery_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(editDelivery_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					oprot.WriteString(structs.GetSuccess());
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(editDelivery_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class editMultiPoDelivery_resultHelper : TBeanSerializer<editMultiPoDelivery_result>
		{
			
			public static editMultiPoDelivery_resultHelper OBJ = new editMultiPoDelivery_resultHelper();
			
			public static editMultiPoDelivery_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(editMultiPoDelivery_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					bool value;
					value = iprot.ReadBool();
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(editMultiPoDelivery_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					oprot.WriteBool((bool)structs.GetSuccess());
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("success can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(editMultiPoDelivery_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getDeliveryGoods_resultHelper : TBeanSerializer<getDeliveryGoods_result>
		{
			
			public static getDeliveryGoods_resultHelper OBJ = new getDeliveryGoods_resultHelper();
			
			public static getDeliveryGoods_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getDeliveryGoods_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					vipapis.delivery.GetDeliveryGoodsResponse value;
					
					value = new vipapis.delivery.GetDeliveryGoodsResponse();
					vipapis.delivery.GetDeliveryGoodsResponseHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getDeliveryGoods_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					vipapis.delivery.GetDeliveryGoodsResponseHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getDeliveryGoods_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getDeliveryList_resultHelper : TBeanSerializer<getDeliveryList_result>
		{
			
			public static getDeliveryList_resultHelper OBJ = new getDeliveryList_resultHelper();
			
			public static getDeliveryList_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getDeliveryList_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					vipapis.delivery.GetDeliveryListResponse value;
					
					value = new vipapis.delivery.GetDeliveryListResponse();
					vipapis.delivery.GetDeliveryListResponseHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getDeliveryList_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					vipapis.delivery.GetDeliveryListResponseHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getDeliveryList_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getMultiPoPickDetail_resultHelper : TBeanSerializer<getMultiPoPickDetail_result>
		{
			
			public static getMultiPoPickDetail_resultHelper OBJ = new getMultiPoPickDetail_resultHelper();
			
			public static getMultiPoPickDetail_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getMultiPoPickDetail_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					vipapis.delivery.GetMultiPoPickDetailResponse value;
					
					value = new vipapis.delivery.GetMultiPoPickDetailResponse();
					vipapis.delivery.GetMultiPoPickDetailResponseHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getMultiPoPickDetail_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					vipapis.delivery.GetMultiPoPickDetailResponseHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getMultiPoPickDetail_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getPickDetail_resultHelper : TBeanSerializer<getPickDetail_result>
		{
			
			public static getPickDetail_resultHelper OBJ = new getPickDetail_resultHelper();
			
			public static getPickDetail_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getPickDetail_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					vipapis.delivery.PickDetail value;
					
					value = new vipapis.delivery.PickDetail();
					vipapis.delivery.PickDetailHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getPickDetail_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					vipapis.delivery.PickDetailHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getPickDetail_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getPickList_resultHelper : TBeanSerializer<getPickList_result>
		{
			
			public static getPickList_resultHelper OBJ = new getPickList_resultHelper();
			
			public static getPickList_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getPickList_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					vipapis.delivery.GetPickListResponse value;
					
					value = new vipapis.delivery.GetPickListResponse();
					vipapis.delivery.GetPickListResponseHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getPickList_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					vipapis.delivery.GetPickListResponseHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getPickList_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class getPoList_resultHelper : TBeanSerializer<getPoList_result>
		{
			
			public static getPoList_resultHelper OBJ = new getPoList_resultHelper();
			
			public static getPoList_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(getPoList_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					vipapis.delivery.Get3PLPoListResponse value;
					
					value = new vipapis.delivery.Get3PLPoListResponse();
					vipapis.delivery.Get3PLPoListResponseHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(getPoList_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					vipapis.delivery.Get3PLPoListResponseHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(getPoList_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class healthCheck_resultHelper : TBeanSerializer<healthCheck_result>
		{
			
			public static healthCheck_resultHelper OBJ = new healthCheck_resultHelper();
			
			public static healthCheck_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(healthCheck_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					com.vip.hermes.core.health.CheckResult value;
					
					value = new com.vip.hermes.core.health.CheckResult();
					com.vip.hermes.core.health.CheckResultHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(healthCheck_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					com.vip.hermes.core.health.CheckResultHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(healthCheck_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class importDeliveryDetail_resultHelper : TBeanSerializer<importDeliveryDetail_result>
		{
			
			public static importDeliveryDetail_resultHelper OBJ = new importDeliveryDetail_resultHelper();
			
			public static importDeliveryDetail_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(importDeliveryDetail_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(importDeliveryDetail_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					oprot.WriteString(structs.GetSuccess());
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(importDeliveryDetail_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class importMultiPoDeliveryDetail_resultHelper : TBeanSerializer<importMultiPoDeliveryDetail_result>
		{
			
			public static importMultiPoDeliveryDetail_resultHelper OBJ = new importMultiPoDeliveryDetail_resultHelper();
			
			public static importMultiPoDeliveryDetail_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(importMultiPoDeliveryDetail_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(importMultiPoDeliveryDetail_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					oprot.WriteString(structs.GetSuccess());
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(importMultiPoDeliveryDetail_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class Jit3PLDeliveryServiceClient : OspRestStub , Jit3PLDeliveryService  {
			
			
			public Jit3PLDeliveryServiceClient():base("vipapis.delivery.Jit3PLDeliveryService","1.0.0") {
				
				
			}
			
			
			
			public string confirmDelivery(int operator_id_,string storage_no_,string store_sn_) {
				
				send_confirmDelivery(operator_id_,storage_no_,store_sn_);
				return recv_confirmDelivery(); 
				
			}
			
			
			private void send_confirmDelivery(int operator_id_,string storage_no_,string store_sn_){
				
				InitInvocation("confirmDelivery");
				
				confirmDelivery_args args = new confirmDelivery_args();
				args.SetOperator_id(operator_id_);
				args.SetStorage_no(storage_no_);
				args.SetStore_sn(store_sn_);
				
				SendBase(args, confirmDelivery_argsHelper.getInstance());
			}
			
			
			private string recv_confirmDelivery(){
				
				confirmDelivery_result result = new confirmDelivery_result();
				ReceiveBase(result, confirmDelivery_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public vipapis.delivery.CreateDeliveryResponse createDelivery(int operator_id_,string po_no_,string delivery_no_,vipapis.common.Warehouse? warehouse_,string delivery_time_,string arrival_time_,string carrier_name_,string delivery_method_,string store_sn_,string carrier_code_) {
				
				send_createDelivery(operator_id_,po_no_,delivery_no_,warehouse_,delivery_time_,arrival_time_,carrier_name_,delivery_method_,store_sn_,carrier_code_);
				return recv_createDelivery(); 
				
			}
			
			
			private void send_createDelivery(int operator_id_,string po_no_,string delivery_no_,vipapis.common.Warehouse? warehouse_,string delivery_time_,string arrival_time_,string carrier_name_,string delivery_method_,string store_sn_,string carrier_code_){
				
				InitInvocation("createDelivery");
				
				createDelivery_args args = new createDelivery_args();
				args.SetOperator_id(operator_id_);
				args.SetPo_no(po_no_);
				args.SetDelivery_no(delivery_no_);
				args.SetWarehouse(warehouse_);
				args.SetDelivery_time(delivery_time_);
				args.SetArrival_time(arrival_time_);
				args.SetCarrier_name(carrier_name_);
				args.SetDelivery_method(delivery_method_);
				args.SetStore_sn(store_sn_);
				args.SetCarrier_code(carrier_code_);
				
				SendBase(args, createDelivery_argsHelper.getInstance());
			}
			
			
			private vipapis.delivery.CreateDeliveryResponse recv_createDelivery(){
				
				createDelivery_result result = new createDelivery_result();
				ReceiveBase(result, createDelivery_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public string createMultiPoDelivery(vipapis.delivery.Create3PLMultiPoDeliveryRequest request_) {
				
				send_createMultiPoDelivery(request_);
				return recv_createMultiPoDelivery(); 
				
			}
			
			
			private void send_createMultiPoDelivery(vipapis.delivery.Create3PLMultiPoDeliveryRequest request_){
				
				InitInvocation("createMultiPoDelivery");
				
				createMultiPoDelivery_args args = new createMultiPoDelivery_args();
				args.SetRequest(request_);
				
				SendBase(args, createMultiPoDelivery_argsHelper.getInstance());
			}
			
			
			private string recv_createMultiPoDelivery(){
				
				createMultiPoDelivery_result result = new createMultiPoDelivery_result();
				ReceiveBase(result, createMultiPoDelivery_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public List<vipapis.delivery.SimplePick> createPick(string po_no_,int operator_id_,string warehouse_,string store_sn_) {
				
				send_createPick(po_no_,operator_id_,warehouse_,store_sn_);
				return recv_createPick(); 
				
			}
			
			
			private void send_createPick(string po_no_,int operator_id_,string warehouse_,string store_sn_){
				
				InitInvocation("createPick");
				
				createPick_args args = new createPick_args();
				args.SetPo_no(po_no_);
				args.SetOperator_id(operator_id_);
				args.SetWarehouse(warehouse_);
				args.SetStore_sn(store_sn_);
				
				SendBase(args, createPick_argsHelper.getInstance());
			}
			
			
			private List<vipapis.delivery.SimplePick> recv_createPick(){
				
				createPick_result result = new createPick_result();
				ReceiveBase(result, createPick_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public List<vipapis.delivery.DeleteDeliveryDetail> deleteDeliveryDetail(int operator_id_,string storage_no_,string po_no_) {
				
				send_deleteDeliveryDetail(operator_id_,storage_no_,po_no_);
				return recv_deleteDeliveryDetail(); 
				
			}
			
			
			private void send_deleteDeliveryDetail(int operator_id_,string storage_no_,string po_no_){
				
				InitInvocation("deleteDeliveryDetail");
				
				deleteDeliveryDetail_args args = new deleteDeliveryDetail_args();
				args.SetOperator_id(operator_id_);
				args.SetStorage_no(storage_no_);
				args.SetPo_no(po_no_);
				
				SendBase(args, deleteDeliveryDetail_argsHelper.getInstance());
			}
			
			
			private List<vipapis.delivery.DeleteDeliveryDetail> recv_deleteDeliveryDetail(){
				
				deleteDeliveryDetail_result result = new deleteDeliveryDetail_result();
				ReceiveBase(result, deleteDeliveryDetail_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public string editDelivery(int operator_id_,string storage_no_,string delivery_no_,vipapis.common.Warehouse? warehouse_,string delivery_time_,string arrival_time_,string carrier_name_,string tel_,string driver_,string driver_tel_,string delivery_method_,string store_sn_,string carrier_code_) {
				
				send_editDelivery(operator_id_,storage_no_,delivery_no_,warehouse_,delivery_time_,arrival_time_,carrier_name_,tel_,driver_,driver_tel_,delivery_method_,store_sn_,carrier_code_);
				return recv_editDelivery(); 
				
			}
			
			
			private void send_editDelivery(int operator_id_,string storage_no_,string delivery_no_,vipapis.common.Warehouse? warehouse_,string delivery_time_,string arrival_time_,string carrier_name_,string tel_,string driver_,string driver_tel_,string delivery_method_,string store_sn_,string carrier_code_){
				
				InitInvocation("editDelivery");
				
				editDelivery_args args = new editDelivery_args();
				args.SetOperator_id(operator_id_);
				args.SetStorage_no(storage_no_);
				args.SetDelivery_no(delivery_no_);
				args.SetWarehouse(warehouse_);
				args.SetDelivery_time(delivery_time_);
				args.SetArrival_time(arrival_time_);
				args.SetCarrier_name(carrier_name_);
				args.SetTel(tel_);
				args.SetDriver(driver_);
				args.SetDriver_tel(driver_tel_);
				args.SetDelivery_method(delivery_method_);
				args.SetStore_sn(store_sn_);
				args.SetCarrier_code(carrier_code_);
				
				SendBase(args, editDelivery_argsHelper.getInstance());
			}
			
			
			private string recv_editDelivery(){
				
				editDelivery_result result = new editDelivery_result();
				ReceiveBase(result, editDelivery_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public bool? editMultiPoDelivery(vipapis.delivery.Edit3PLMultiPoDeliveryRequest request_) {
				
				send_editMultiPoDelivery(request_);
				return recv_editMultiPoDelivery(); 
				
			}
			
			
			private void send_editMultiPoDelivery(vipapis.delivery.Edit3PLMultiPoDeliveryRequest request_){
				
				InitInvocation("editMultiPoDelivery");
				
				editMultiPoDelivery_args args = new editMultiPoDelivery_args();
				args.SetRequest(request_);
				
				SendBase(args, editMultiPoDelivery_argsHelper.getInstance());
			}
			
			
			private bool? recv_editMultiPoDelivery(){
				
				editMultiPoDelivery_result result = new editMultiPoDelivery_result();
				ReceiveBase(result, editMultiPoDelivery_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public vipapis.delivery.GetDeliveryGoodsResponse getDeliveryGoods(int operator_id_,string storage_no_,int? page_,int? limit_) {
				
				send_getDeliveryGoods(operator_id_,storage_no_,page_,limit_);
				return recv_getDeliveryGoods(); 
				
			}
			
			
			private void send_getDeliveryGoods(int operator_id_,string storage_no_,int? page_,int? limit_){
				
				InitInvocation("getDeliveryGoods");
				
				getDeliveryGoods_args args = new getDeliveryGoods_args();
				args.SetOperator_id(operator_id_);
				args.SetStorage_no(storage_no_);
				args.SetPage(page_);
				args.SetLimit(limit_);
				
				SendBase(args, getDeliveryGoods_argsHelper.getInstance());
			}
			
			
			private vipapis.delivery.GetDeliveryGoodsResponse recv_getDeliveryGoods(){
				
				getDeliveryGoods_result result = new getDeliveryGoods_result();
				ReceiveBase(result, getDeliveryGoods_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public vipapis.delivery.GetDeliveryListResponse getDeliveryList(int operator_id_,string po_no_,string delivery_no_,vipapis.common.Warehouse? warehouse_,string out_flag_,string st_out_time_,string et_out_time_,string st_estimate_arrive_time_,string et_estimate_arrive_time_,string st_arrive_time_,string et_arrive_time_,int? page_,int? limit_,string store_sn_,string storage_no_) {
				
				send_getDeliveryList(operator_id_,po_no_,delivery_no_,warehouse_,out_flag_,st_out_time_,et_out_time_,st_estimate_arrive_time_,et_estimate_arrive_time_,st_arrive_time_,et_arrive_time_,page_,limit_,store_sn_,storage_no_);
				return recv_getDeliveryList(); 
				
			}
			
			
			private void send_getDeliveryList(int operator_id_,string po_no_,string delivery_no_,vipapis.common.Warehouse? warehouse_,string out_flag_,string st_out_time_,string et_out_time_,string st_estimate_arrive_time_,string et_estimate_arrive_time_,string st_arrive_time_,string et_arrive_time_,int? page_,int? limit_,string store_sn_,string storage_no_){
				
				InitInvocation("getDeliveryList");
				
				getDeliveryList_args args = new getDeliveryList_args();
				args.SetOperator_id(operator_id_);
				args.SetPo_no(po_no_);
				args.SetDelivery_no(delivery_no_);
				args.SetWarehouse(warehouse_);
				args.SetOut_flag(out_flag_);
				args.SetSt_out_time(st_out_time_);
				args.SetEt_out_time(et_out_time_);
				args.SetSt_estimate_arrive_time(st_estimate_arrive_time_);
				args.SetEt_estimate_arrive_time(et_estimate_arrive_time_);
				args.SetSt_arrive_time(st_arrive_time_);
				args.SetEt_arrive_time(et_arrive_time_);
				args.SetPage(page_);
				args.SetLimit(limit_);
				args.SetStore_sn(store_sn_);
				args.SetStorage_no(storage_no_);
				
				SendBase(args, getDeliveryList_argsHelper.getInstance());
			}
			
			
			private vipapis.delivery.GetDeliveryListResponse recv_getDeliveryList(){
				
				getDeliveryList_result result = new getDeliveryList_result();
				ReceiveBase(result, getDeliveryList_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public vipapis.delivery.GetMultiPoPickDetailResponse getMultiPoPickDetail(vipapis.delivery.Get3PLMultiPoPickDetailRequest request_) {
				
				send_getMultiPoPickDetail(request_);
				return recv_getMultiPoPickDetail(); 
				
			}
			
			
			private void send_getMultiPoPickDetail(vipapis.delivery.Get3PLMultiPoPickDetailRequest request_){
				
				InitInvocation("getMultiPoPickDetail");
				
				getMultiPoPickDetail_args args = new getMultiPoPickDetail_args();
				args.SetRequest(request_);
				
				SendBase(args, getMultiPoPickDetail_argsHelper.getInstance());
			}
			
			
			private vipapis.delivery.GetMultiPoPickDetailResponse recv_getMultiPoPickDetail(){
				
				getMultiPoPickDetail_result result = new getMultiPoPickDetail_result();
				ReceiveBase(result, getMultiPoPickDetail_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public vipapis.delivery.PickDetail getPickDetail(string po_no_,int operator_id_,string pick_no_,int? page_,int? limit_) {
				
				send_getPickDetail(po_no_,operator_id_,pick_no_,page_,limit_);
				return recv_getPickDetail(); 
				
			}
			
			
			private void send_getPickDetail(string po_no_,int operator_id_,string pick_no_,int? page_,int? limit_){
				
				InitInvocation("getPickDetail");
				
				getPickDetail_args args = new getPickDetail_args();
				args.SetPo_no(po_no_);
				args.SetOperator_id(operator_id_);
				args.SetPick_no(pick_no_);
				args.SetPage(page_);
				args.SetLimit(limit_);
				
				SendBase(args, getPickDetail_argsHelper.getInstance());
			}
			
			
			private vipapis.delivery.PickDetail recv_getPickDetail(){
				
				getPickDetail_result result = new getPickDetail_result();
				ReceiveBase(result, getPickDetail_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public vipapis.delivery.GetPickListResponse getPickList(int operator_id_,string po_no_,string pick_no_,vipapis.common.Warehouse? warehouse_,string co_mode_,string order_cate_,string st_create_time_,string et_create_time_,string st_sell_time_from_,string et_sell_time_from_,int? is_export_,int? page_,int? limit_,string store_sn_) {
				
				send_getPickList(operator_id_,po_no_,pick_no_,warehouse_,co_mode_,order_cate_,st_create_time_,et_create_time_,st_sell_time_from_,et_sell_time_from_,is_export_,page_,limit_,store_sn_);
				return recv_getPickList(); 
				
			}
			
			
			private void send_getPickList(int operator_id_,string po_no_,string pick_no_,vipapis.common.Warehouse? warehouse_,string co_mode_,string order_cate_,string st_create_time_,string et_create_time_,string st_sell_time_from_,string et_sell_time_from_,int? is_export_,int? page_,int? limit_,string store_sn_){
				
				InitInvocation("getPickList");
				
				getPickList_args args = new getPickList_args();
				args.SetOperator_id(operator_id_);
				args.SetPo_no(po_no_);
				args.SetPick_no(pick_no_);
				args.SetWarehouse(warehouse_);
				args.SetCo_mode(co_mode_);
				args.SetOrder_cate(order_cate_);
				args.SetSt_create_time(st_create_time_);
				args.SetEt_create_time(et_create_time_);
				args.SetSt_sell_time_from(st_sell_time_from_);
				args.SetEt_sell_time_from(et_sell_time_from_);
				args.SetIs_export(is_export_);
				args.SetPage(page_);
				args.SetLimit(limit_);
				args.SetStore_sn(store_sn_);
				
				SendBase(args, getPickList_argsHelper.getInstance());
			}
			
			
			private vipapis.delivery.GetPickListResponse recv_getPickList(){
				
				getPickList_result result = new getPickList_result();
				ReceiveBase(result, getPickList_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public vipapis.delivery.Get3PLPoListResponse getPoList(string po_no_,string co_mode_,int operator_id_,string st_sell_st_time_,string et_sell_st_time_,string st_po_start_time_,string et_po_start_time_,int? page_,int? limit_) {
				
				send_getPoList(po_no_,co_mode_,operator_id_,st_sell_st_time_,et_sell_st_time_,st_po_start_time_,et_po_start_time_,page_,limit_);
				return recv_getPoList(); 
				
			}
			
			
			private void send_getPoList(string po_no_,string co_mode_,int operator_id_,string st_sell_st_time_,string et_sell_st_time_,string st_po_start_time_,string et_po_start_time_,int? page_,int? limit_){
				
				InitInvocation("getPoList");
				
				getPoList_args args = new getPoList_args();
				args.SetPo_no(po_no_);
				args.SetCo_mode(co_mode_);
				args.SetOperator_id(operator_id_);
				args.SetSt_sell_st_time(st_sell_st_time_);
				args.SetEt_sell_st_time(et_sell_st_time_);
				args.SetSt_po_start_time(st_po_start_time_);
				args.SetEt_po_start_time(et_po_start_time_);
				args.SetPage(page_);
				args.SetLimit(limit_);
				
				SendBase(args, getPoList_argsHelper.getInstance());
			}
			
			
			private vipapis.delivery.Get3PLPoListResponse recv_getPoList(){
				
				getPoList_result result = new getPoList_result();
				ReceiveBase(result, getPoList_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public com.vip.hermes.core.health.CheckResult healthCheck() {
				
				send_healthCheck();
				return recv_healthCheck(); 
				
			}
			
			
			private void send_healthCheck(){
				
				InitInvocation("healthCheck");
				
				healthCheck_args args = new healthCheck_args();
				
				SendBase(args, healthCheck_argsHelper.getInstance());
			}
			
			
			private com.vip.hermes.core.health.CheckResult recv_healthCheck(){
				
				healthCheck_result result = new healthCheck_result();
				ReceiveBase(result, healthCheck_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public string importDeliveryDetail(int operator_id_,string po_no_,string storage_no_,string store_sn_,List<vipapis.delivery.Delivery> delivery_list_) {
				
				send_importDeliveryDetail(operator_id_,po_no_,storage_no_,store_sn_,delivery_list_);
				return recv_importDeliveryDetail(); 
				
			}
			
			
			private void send_importDeliveryDetail(int operator_id_,string po_no_,string storage_no_,string store_sn_,List<vipapis.delivery.Delivery> delivery_list_){
				
				InitInvocation("importDeliveryDetail");
				
				importDeliveryDetail_args args = new importDeliveryDetail_args();
				args.SetOperator_id(operator_id_);
				args.SetPo_no(po_no_);
				args.SetStorage_no(storage_no_);
				args.SetStore_sn(store_sn_);
				args.SetDelivery_list(delivery_list_);
				
				SendBase(args, importDeliveryDetail_argsHelper.getInstance());
			}
			
			
			private string recv_importDeliveryDetail(){
				
				importDeliveryDetail_result result = new importDeliveryDetail_result();
				ReceiveBase(result, importDeliveryDetail_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public string importMultiPoDeliveryDetail(int operator_id_,string po_no_,string storage_no_,string store_sn_,List<vipapis.delivery.Delivery> delivery_list_) {
				
				send_importMultiPoDeliveryDetail(operator_id_,po_no_,storage_no_,store_sn_,delivery_list_);
				return recv_importMultiPoDeliveryDetail(); 
				
			}
			
			
			private void send_importMultiPoDeliveryDetail(int operator_id_,string po_no_,string storage_no_,string store_sn_,List<vipapis.delivery.Delivery> delivery_list_){
				
				InitInvocation("importMultiPoDeliveryDetail");
				
				importMultiPoDeliveryDetail_args args = new importMultiPoDeliveryDetail_args();
				args.SetOperator_id(operator_id_);
				args.SetPo_no(po_no_);
				args.SetStorage_no(storage_no_);
				args.SetStore_sn(store_sn_);
				args.SetDelivery_list(delivery_list_);
				
				SendBase(args, importMultiPoDeliveryDetail_argsHelper.getInstance());
			}
			
			
			private string recv_importMultiPoDeliveryDetail(){
				
				importMultiPoDeliveryDetail_result result = new importMultiPoDeliveryDetail_result();
				ReceiveBase(result, importMultiPoDeliveryDetail_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
		}
		
		
	}
	
}