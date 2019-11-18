using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;

namespace vipapis.xstore.cc.bulkbuying.api{
	
	
	public class PurchaseOrderServiceHelper {
		
		
		
		public class confirmPoWarehouseReceipt_args {
			
			///<summary>
			/// 回传采购单的入库单号请求体
			///</summary>
			
			private vipapis.xstore.cc.bulkbuying.api.ConfirmPoWarehouseReceiptReq req_;
			
			public vipapis.xstore.cc.bulkbuying.api.ConfirmPoWarehouseReceiptReq GetReq(){
				return this.req_;
			}
			
			public void SetReq(vipapis.xstore.cc.bulkbuying.api.ConfirmPoWarehouseReceiptReq value){
				this.req_ = value;
			}
			
		}
		
		
		
		
		public class confirmPurchaseOrder_args {
			
			///<summary>
			/// 采购单号
			///</summary>
			
			private string purchaseNo_;
			
			public string GetPurchaseNo(){
				return this.purchaseNo_;
			}
			
			public void SetPurchaseNo(string value){
				this.purchaseNo_ = value;
			}
			
		}
		
		
		
		
		public class healthCheck_args {
			
			
		}
		
		
		
		
		public class queryPoWarehouseReceipt_args {
			
			///<summary>
			/// 查询采购单入库信息请求体
			///</summary>
			
			private vipapis.xstore.cc.bulkbuying.api.QueryPoWarehouseReceiptReq req_;
			
			public vipapis.xstore.cc.bulkbuying.api.QueryPoWarehouseReceiptReq GetReq(){
				return this.req_;
			}
			
			public void SetReq(vipapis.xstore.cc.bulkbuying.api.QueryPoWarehouseReceiptReq value){
				this.req_ = value;
			}
			
		}
		
		
		
		
		public class queryPoWarehouseReceiptItem_args {
			
			///<summary>
			/// 查询采购单入库单详细信息请求体
			///</summary>
			
			private vipapis.xstore.cc.bulkbuying.api.QueryPoWarehouseReceiptItemReq req_;
			
			public vipapis.xstore.cc.bulkbuying.api.QueryPoWarehouseReceiptItemReq GetReq(){
				return this.req_;
			}
			
			public void SetReq(vipapis.xstore.cc.bulkbuying.api.QueryPoWarehouseReceiptItemReq value){
				this.req_ = value;
			}
			
		}
		
		
		
		
		public class queryPurchaseOrder_args {
			
			///<summary>
			/// 查询采购单请求结构体
			///</summary>
			
			private vipapis.xstore.cc.bulkbuying.api.QueryPurchaseOrderReq req_;
			
			public vipapis.xstore.cc.bulkbuying.api.QueryPurchaseOrderReq GetReq(){
				return this.req_;
			}
			
			public void SetReq(vipapis.xstore.cc.bulkbuying.api.QueryPurchaseOrderReq value){
				this.req_ = value;
			}
			
		}
		
		
		
		
		public class queryPurchaseOrderItem_args {
			
			///<summary>
			/// 查询采购单明细
			///</summary>
			
			private vipapis.xstore.cc.bulkbuying.api.QueryPurchaseOrderItemReq req_;
			
			public vipapis.xstore.cc.bulkbuying.api.QueryPurchaseOrderItemReq GetReq(){
				return this.req_;
			}
			
			public void SetReq(vipapis.xstore.cc.bulkbuying.api.QueryPurchaseOrderItemReq value){
				this.req_ = value;
			}
			
		}
		
		
		
		
		public class updatePoWarehouseReceiptQty_args {
			
			///<summary>
			/// 更新采购单入库数量请求
			///</summary>
			
			private vipapis.xstore.cc.bulkbuying.api.UpdatePoWarehouseReceiptQtyReq req_;
			
			public vipapis.xstore.cc.bulkbuying.api.UpdatePoWarehouseReceiptQtyReq GetReq(){
				return this.req_;
			}
			
			public void SetReq(vipapis.xstore.cc.bulkbuying.api.UpdatePoWarehouseReceiptQtyReq value){
				this.req_ = value;
			}
			
		}
		
		
		
		
		public class confirmPoWarehouseReceipt_result {
			
			///<summary>
			///</summary>
			
			private vipapis.xstore.cc.bulkbuying.api.ConfirmPoWarehouseReceiptResp success_;
			
			public vipapis.xstore.cc.bulkbuying.api.ConfirmPoWarehouseReceiptResp GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(vipapis.xstore.cc.bulkbuying.api.ConfirmPoWarehouseReceiptResp value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class confirmPurchaseOrder_result {
			
			///<summary>
			///</summary>
			
			private vipapis.xstore.cc.bulkbuying.api.ConfirmPurchaseOrderResp success_;
			
			public vipapis.xstore.cc.bulkbuying.api.ConfirmPurchaseOrderResp GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(vipapis.xstore.cc.bulkbuying.api.ConfirmPurchaseOrderResp value){
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
		
		
		
		
		public class queryPoWarehouseReceipt_result {
			
			///<summary>
			///</summary>
			
			private vipapis.xstore.cc.bulkbuying.api.QueryPoWarehouseReceiptResp success_;
			
			public vipapis.xstore.cc.bulkbuying.api.QueryPoWarehouseReceiptResp GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(vipapis.xstore.cc.bulkbuying.api.QueryPoWarehouseReceiptResp value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class queryPoWarehouseReceiptItem_result {
			
			///<summary>
			///</summary>
			
			private vipapis.xstore.cc.bulkbuying.api.QueryPoWarehouseReceiptItemResp success_;
			
			public vipapis.xstore.cc.bulkbuying.api.QueryPoWarehouseReceiptItemResp GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(vipapis.xstore.cc.bulkbuying.api.QueryPoWarehouseReceiptItemResp value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class queryPurchaseOrder_result {
			
			///<summary>
			///</summary>
			
			private vipapis.xstore.cc.bulkbuying.api.QueryPurchaseOrderResp success_;
			
			public vipapis.xstore.cc.bulkbuying.api.QueryPurchaseOrderResp GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(vipapis.xstore.cc.bulkbuying.api.QueryPurchaseOrderResp value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class queryPurchaseOrderItem_result {
			
			///<summary>
			///</summary>
			
			private vipapis.xstore.cc.bulkbuying.api.QueryPurchaseOrderItemResp success_;
			
			public vipapis.xstore.cc.bulkbuying.api.QueryPurchaseOrderItemResp GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(vipapis.xstore.cc.bulkbuying.api.QueryPurchaseOrderItemResp value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		public class updatePoWarehouseReceiptQty_result {
			
			///<summary>
			///</summary>
			
			private Dictionary<string, vipapis.xstore.cc.bulkbuying.api.UpdatePoWarehouseReceiptQtyResult> success_;
			
			public Dictionary<string, vipapis.xstore.cc.bulkbuying.api.UpdatePoWarehouseReceiptQtyResult> GetSuccess(){
				return this.success_;
			}
			
			public void SetSuccess(Dictionary<string, vipapis.xstore.cc.bulkbuying.api.UpdatePoWarehouseReceiptQtyResult> value){
				this.success_ = value;
			}
			
		}
		
		
		
		
		
		public class confirmPoWarehouseReceipt_argsHelper : TBeanSerializer<confirmPoWarehouseReceipt_args>
		{
			
			public static confirmPoWarehouseReceipt_argsHelper OBJ = new confirmPoWarehouseReceipt_argsHelper();
			
			public static confirmPoWarehouseReceipt_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(confirmPoWarehouseReceipt_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					vipapis.xstore.cc.bulkbuying.api.ConfirmPoWarehouseReceiptReq value;
					
					value = new vipapis.xstore.cc.bulkbuying.api.ConfirmPoWarehouseReceiptReq();
					vipapis.xstore.cc.bulkbuying.api.ConfirmPoWarehouseReceiptReqHelper.getInstance().Read(value, iprot);
					
					structs.SetReq(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(confirmPoWarehouseReceipt_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetReq() != null) {
					
					oprot.WriteFieldBegin("req");
					
					vipapis.xstore.cc.bulkbuying.api.ConfirmPoWarehouseReceiptReqHelper.getInstance().Write(structs.GetReq(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(confirmPoWarehouseReceipt_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class confirmPurchaseOrder_argsHelper : TBeanSerializer<confirmPurchaseOrder_args>
		{
			
			public static confirmPurchaseOrder_argsHelper OBJ = new confirmPurchaseOrder_argsHelper();
			
			public static confirmPurchaseOrder_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(confirmPurchaseOrder_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					string value;
					value = iprot.ReadString();
					
					structs.SetPurchaseNo(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(confirmPurchaseOrder_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetPurchaseNo() != null) {
					
					oprot.WriteFieldBegin("purchaseNo");
					oprot.WriteString(structs.GetPurchaseNo());
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("purchaseNo can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(confirmPurchaseOrder_args bean){
				
				
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
		
		
		
		
		public class queryPoWarehouseReceipt_argsHelper : TBeanSerializer<queryPoWarehouseReceipt_args>
		{
			
			public static queryPoWarehouseReceipt_argsHelper OBJ = new queryPoWarehouseReceipt_argsHelper();
			
			public static queryPoWarehouseReceipt_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(queryPoWarehouseReceipt_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					vipapis.xstore.cc.bulkbuying.api.QueryPoWarehouseReceiptReq value;
					
					value = new vipapis.xstore.cc.bulkbuying.api.QueryPoWarehouseReceiptReq();
					vipapis.xstore.cc.bulkbuying.api.QueryPoWarehouseReceiptReqHelper.getInstance().Read(value, iprot);
					
					structs.SetReq(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(queryPoWarehouseReceipt_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetReq() != null) {
					
					oprot.WriteFieldBegin("req");
					
					vipapis.xstore.cc.bulkbuying.api.QueryPoWarehouseReceiptReqHelper.getInstance().Write(structs.GetReq(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(queryPoWarehouseReceipt_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class queryPoWarehouseReceiptItem_argsHelper : TBeanSerializer<queryPoWarehouseReceiptItem_args>
		{
			
			public static queryPoWarehouseReceiptItem_argsHelper OBJ = new queryPoWarehouseReceiptItem_argsHelper();
			
			public static queryPoWarehouseReceiptItem_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(queryPoWarehouseReceiptItem_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					vipapis.xstore.cc.bulkbuying.api.QueryPoWarehouseReceiptItemReq value;
					
					value = new vipapis.xstore.cc.bulkbuying.api.QueryPoWarehouseReceiptItemReq();
					vipapis.xstore.cc.bulkbuying.api.QueryPoWarehouseReceiptItemReqHelper.getInstance().Read(value, iprot);
					
					structs.SetReq(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(queryPoWarehouseReceiptItem_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetReq() != null) {
					
					oprot.WriteFieldBegin("req");
					
					vipapis.xstore.cc.bulkbuying.api.QueryPoWarehouseReceiptItemReqHelper.getInstance().Write(structs.GetReq(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(queryPoWarehouseReceiptItem_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class queryPurchaseOrder_argsHelper : TBeanSerializer<queryPurchaseOrder_args>
		{
			
			public static queryPurchaseOrder_argsHelper OBJ = new queryPurchaseOrder_argsHelper();
			
			public static queryPurchaseOrder_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(queryPurchaseOrder_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					vipapis.xstore.cc.bulkbuying.api.QueryPurchaseOrderReq value;
					
					value = new vipapis.xstore.cc.bulkbuying.api.QueryPurchaseOrderReq();
					vipapis.xstore.cc.bulkbuying.api.QueryPurchaseOrderReqHelper.getInstance().Read(value, iprot);
					
					structs.SetReq(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(queryPurchaseOrder_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetReq() != null) {
					
					oprot.WriteFieldBegin("req");
					
					vipapis.xstore.cc.bulkbuying.api.QueryPurchaseOrderReqHelper.getInstance().Write(structs.GetReq(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("req can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(queryPurchaseOrder_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class queryPurchaseOrderItem_argsHelper : TBeanSerializer<queryPurchaseOrderItem_args>
		{
			
			public static queryPurchaseOrderItem_argsHelper OBJ = new queryPurchaseOrderItem_argsHelper();
			
			public static queryPurchaseOrderItem_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(queryPurchaseOrderItem_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					vipapis.xstore.cc.bulkbuying.api.QueryPurchaseOrderItemReq value;
					
					value = new vipapis.xstore.cc.bulkbuying.api.QueryPurchaseOrderItemReq();
					vipapis.xstore.cc.bulkbuying.api.QueryPurchaseOrderItemReqHelper.getInstance().Read(value, iprot);
					
					structs.SetReq(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(queryPurchaseOrderItem_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetReq() != null) {
					
					oprot.WriteFieldBegin("req");
					
					vipapis.xstore.cc.bulkbuying.api.QueryPurchaseOrderItemReqHelper.getInstance().Write(structs.GetReq(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("req can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(queryPurchaseOrderItem_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class updatePoWarehouseReceiptQty_argsHelper : TBeanSerializer<updatePoWarehouseReceiptQty_args>
		{
			
			public static updatePoWarehouseReceiptQty_argsHelper OBJ = new updatePoWarehouseReceiptQty_argsHelper();
			
			public static updatePoWarehouseReceiptQty_argsHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(updatePoWarehouseReceiptQty_args structs, Protocol iprot){
				
				
				
				
				if(true){
					
					vipapis.xstore.cc.bulkbuying.api.UpdatePoWarehouseReceiptQtyReq value;
					
					value = new vipapis.xstore.cc.bulkbuying.api.UpdatePoWarehouseReceiptQtyReq();
					vipapis.xstore.cc.bulkbuying.api.UpdatePoWarehouseReceiptQtyReqHelper.getInstance().Read(value, iprot);
					
					structs.SetReq(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(updatePoWarehouseReceiptQty_args structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetReq() != null) {
					
					oprot.WriteFieldBegin("req");
					
					vipapis.xstore.cc.bulkbuying.api.UpdatePoWarehouseReceiptQtyReqHelper.getInstance().Write(structs.GetReq(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				else{
					throw new ArgumentException("req can not be null!");
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(updatePoWarehouseReceiptQty_args bean){
				
				
			}
			
			
		}
		
		
		
		
		public class confirmPoWarehouseReceipt_resultHelper : TBeanSerializer<confirmPoWarehouseReceipt_result>
		{
			
			public static confirmPoWarehouseReceipt_resultHelper OBJ = new confirmPoWarehouseReceipt_resultHelper();
			
			public static confirmPoWarehouseReceipt_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(confirmPoWarehouseReceipt_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					vipapis.xstore.cc.bulkbuying.api.ConfirmPoWarehouseReceiptResp value;
					
					value = new vipapis.xstore.cc.bulkbuying.api.ConfirmPoWarehouseReceiptResp();
					vipapis.xstore.cc.bulkbuying.api.ConfirmPoWarehouseReceiptRespHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(confirmPoWarehouseReceipt_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					vipapis.xstore.cc.bulkbuying.api.ConfirmPoWarehouseReceiptRespHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(confirmPoWarehouseReceipt_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class confirmPurchaseOrder_resultHelper : TBeanSerializer<confirmPurchaseOrder_result>
		{
			
			public static confirmPurchaseOrder_resultHelper OBJ = new confirmPurchaseOrder_resultHelper();
			
			public static confirmPurchaseOrder_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(confirmPurchaseOrder_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					vipapis.xstore.cc.bulkbuying.api.ConfirmPurchaseOrderResp value;
					
					value = new vipapis.xstore.cc.bulkbuying.api.ConfirmPurchaseOrderResp();
					vipapis.xstore.cc.bulkbuying.api.ConfirmPurchaseOrderRespHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(confirmPurchaseOrder_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					vipapis.xstore.cc.bulkbuying.api.ConfirmPurchaseOrderRespHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(confirmPurchaseOrder_result bean){
				
				
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
		
		
		
		
		public class queryPoWarehouseReceipt_resultHelper : TBeanSerializer<queryPoWarehouseReceipt_result>
		{
			
			public static queryPoWarehouseReceipt_resultHelper OBJ = new queryPoWarehouseReceipt_resultHelper();
			
			public static queryPoWarehouseReceipt_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(queryPoWarehouseReceipt_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					vipapis.xstore.cc.bulkbuying.api.QueryPoWarehouseReceiptResp value;
					
					value = new vipapis.xstore.cc.bulkbuying.api.QueryPoWarehouseReceiptResp();
					vipapis.xstore.cc.bulkbuying.api.QueryPoWarehouseReceiptRespHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(queryPoWarehouseReceipt_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					vipapis.xstore.cc.bulkbuying.api.QueryPoWarehouseReceiptRespHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(queryPoWarehouseReceipt_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class queryPoWarehouseReceiptItem_resultHelper : TBeanSerializer<queryPoWarehouseReceiptItem_result>
		{
			
			public static queryPoWarehouseReceiptItem_resultHelper OBJ = new queryPoWarehouseReceiptItem_resultHelper();
			
			public static queryPoWarehouseReceiptItem_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(queryPoWarehouseReceiptItem_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					vipapis.xstore.cc.bulkbuying.api.QueryPoWarehouseReceiptItemResp value;
					
					value = new vipapis.xstore.cc.bulkbuying.api.QueryPoWarehouseReceiptItemResp();
					vipapis.xstore.cc.bulkbuying.api.QueryPoWarehouseReceiptItemRespHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(queryPoWarehouseReceiptItem_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					vipapis.xstore.cc.bulkbuying.api.QueryPoWarehouseReceiptItemRespHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(queryPoWarehouseReceiptItem_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class queryPurchaseOrder_resultHelper : TBeanSerializer<queryPurchaseOrder_result>
		{
			
			public static queryPurchaseOrder_resultHelper OBJ = new queryPurchaseOrder_resultHelper();
			
			public static queryPurchaseOrder_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(queryPurchaseOrder_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					vipapis.xstore.cc.bulkbuying.api.QueryPurchaseOrderResp value;
					
					value = new vipapis.xstore.cc.bulkbuying.api.QueryPurchaseOrderResp();
					vipapis.xstore.cc.bulkbuying.api.QueryPurchaseOrderRespHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(queryPurchaseOrder_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					vipapis.xstore.cc.bulkbuying.api.QueryPurchaseOrderRespHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(queryPurchaseOrder_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class queryPurchaseOrderItem_resultHelper : TBeanSerializer<queryPurchaseOrderItem_result>
		{
			
			public static queryPurchaseOrderItem_resultHelper OBJ = new queryPurchaseOrderItem_resultHelper();
			
			public static queryPurchaseOrderItem_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(queryPurchaseOrderItem_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					vipapis.xstore.cc.bulkbuying.api.QueryPurchaseOrderItemResp value;
					
					value = new vipapis.xstore.cc.bulkbuying.api.QueryPurchaseOrderItemResp();
					vipapis.xstore.cc.bulkbuying.api.QueryPurchaseOrderItemRespHelper.getInstance().Read(value, iprot);
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(queryPurchaseOrderItem_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					vipapis.xstore.cc.bulkbuying.api.QueryPurchaseOrderItemRespHelper.getInstance().Write(structs.GetSuccess(), oprot);
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(queryPurchaseOrderItem_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class updatePoWarehouseReceiptQty_resultHelper : TBeanSerializer<updatePoWarehouseReceiptQty_result>
		{
			
			public static updatePoWarehouseReceiptQty_resultHelper OBJ = new updatePoWarehouseReceiptQty_resultHelper();
			
			public static updatePoWarehouseReceiptQty_resultHelper getInstance() {
				
				return OBJ;
			}
			
			
			public void Read(updatePoWarehouseReceiptQty_result structs, Protocol iprot){
				
				
				
				
				if(true){
					
					Dictionary<string, vipapis.xstore.cc.bulkbuying.api.UpdatePoWarehouseReceiptQtyResult> value;
					
					value = new Dictionary<string, vipapis.xstore.cc.bulkbuying.api.UpdatePoWarehouseReceiptQtyResult>();
					iprot.ReadMapBegin();
					while(true){
						
						try{
							
							string _key0;
							vipapis.xstore.cc.bulkbuying.api.UpdatePoWarehouseReceiptQtyResult _val0;
							_key0 = iprot.ReadString();
							
							
							_val0 = new vipapis.xstore.cc.bulkbuying.api.UpdatePoWarehouseReceiptQtyResult();
							vipapis.xstore.cc.bulkbuying.api.UpdatePoWarehouseReceiptQtyResultHelper.getInstance().Read(_val0, iprot);
							
							value.Add(_key0, _val0);
						}
						catch(Exception e){
							
							
							break;
						}
					}
					
					iprot.ReadMapEnd();
					
					structs.SetSuccess(value);
				}
				
				
				
				
				Validate(structs);
				
			}
			
			
			public void Write(updatePoWarehouseReceiptQty_result structs, Protocol oprot){
				
				Validate(structs);
				oprot.WriteStructBegin();
				
				if(structs.GetSuccess() != null) {
					
					oprot.WriteFieldBegin("success");
					
					oprot.WriteMapBegin();
					foreach(KeyValuePair< string, vipapis.xstore.cc.bulkbuying.api.UpdatePoWarehouseReceiptQtyResult > _ir0 in structs.GetSuccess()){
						
						string _key0 = _ir0.Key;
						vipapis.xstore.cc.bulkbuying.api.UpdatePoWarehouseReceiptQtyResult _value0 = _ir0.Value;
						oprot.WriteString(_key0);
						
						
						vipapis.xstore.cc.bulkbuying.api.UpdatePoWarehouseReceiptQtyResultHelper.getInstance().Write(_value0, oprot);
						
					}
					
					oprot.WriteMapEnd();
					
					oprot.WriteFieldEnd();
				}
				
				
				oprot.WriteFieldStop();
				oprot.WriteStructEnd();
			}
			
			
			public void Validate(updatePoWarehouseReceiptQty_result bean){
				
				
			}
			
			
		}
		
		
		
		
		public class PurchaseOrderServiceClient : OspRestStub , PurchaseOrderService  {
			
			
			public PurchaseOrderServiceClient():base("vipapis.xstore.cc.bulkbuying.api.PurchaseOrderService","1.0.0") {
				
				
			}
			
			
			
			public vipapis.xstore.cc.bulkbuying.api.ConfirmPoWarehouseReceiptResp confirmPoWarehouseReceipt(vipapis.xstore.cc.bulkbuying.api.ConfirmPoWarehouseReceiptReq req_) {
				
				send_confirmPoWarehouseReceipt(req_);
				return recv_confirmPoWarehouseReceipt(); 
				
			}
			
			
			private void send_confirmPoWarehouseReceipt(vipapis.xstore.cc.bulkbuying.api.ConfirmPoWarehouseReceiptReq req_){
				
				InitInvocation("confirmPoWarehouseReceipt");
				
				confirmPoWarehouseReceipt_args args = new confirmPoWarehouseReceipt_args();
				args.SetReq(req_);
				
				SendBase(args, confirmPoWarehouseReceipt_argsHelper.getInstance());
			}
			
			
			private vipapis.xstore.cc.bulkbuying.api.ConfirmPoWarehouseReceiptResp recv_confirmPoWarehouseReceipt(){
				
				confirmPoWarehouseReceipt_result result = new confirmPoWarehouseReceipt_result();
				ReceiveBase(result, confirmPoWarehouseReceipt_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public vipapis.xstore.cc.bulkbuying.api.ConfirmPurchaseOrderResp confirmPurchaseOrder(string purchaseNo_) {
				
				send_confirmPurchaseOrder(purchaseNo_);
				return recv_confirmPurchaseOrder(); 
				
			}
			
			
			private void send_confirmPurchaseOrder(string purchaseNo_){
				
				InitInvocation("confirmPurchaseOrder");
				
				confirmPurchaseOrder_args args = new confirmPurchaseOrder_args();
				args.SetPurchaseNo(purchaseNo_);
				
				SendBase(args, confirmPurchaseOrder_argsHelper.getInstance());
			}
			
			
			private vipapis.xstore.cc.bulkbuying.api.ConfirmPurchaseOrderResp recv_confirmPurchaseOrder(){
				
				confirmPurchaseOrder_result result = new confirmPurchaseOrder_result();
				ReceiveBase(result, confirmPurchaseOrder_resultHelper.getInstance());
				
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
			
			
			public vipapis.xstore.cc.bulkbuying.api.QueryPoWarehouseReceiptResp queryPoWarehouseReceipt(vipapis.xstore.cc.bulkbuying.api.QueryPoWarehouseReceiptReq req_) {
				
				send_queryPoWarehouseReceipt(req_);
				return recv_queryPoWarehouseReceipt(); 
				
			}
			
			
			private void send_queryPoWarehouseReceipt(vipapis.xstore.cc.bulkbuying.api.QueryPoWarehouseReceiptReq req_){
				
				InitInvocation("queryPoWarehouseReceipt");
				
				queryPoWarehouseReceipt_args args = new queryPoWarehouseReceipt_args();
				args.SetReq(req_);
				
				SendBase(args, queryPoWarehouseReceipt_argsHelper.getInstance());
			}
			
			
			private vipapis.xstore.cc.bulkbuying.api.QueryPoWarehouseReceiptResp recv_queryPoWarehouseReceipt(){
				
				queryPoWarehouseReceipt_result result = new queryPoWarehouseReceipt_result();
				ReceiveBase(result, queryPoWarehouseReceipt_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public vipapis.xstore.cc.bulkbuying.api.QueryPoWarehouseReceiptItemResp queryPoWarehouseReceiptItem(vipapis.xstore.cc.bulkbuying.api.QueryPoWarehouseReceiptItemReq req_) {
				
				send_queryPoWarehouseReceiptItem(req_);
				return recv_queryPoWarehouseReceiptItem(); 
				
			}
			
			
			private void send_queryPoWarehouseReceiptItem(vipapis.xstore.cc.bulkbuying.api.QueryPoWarehouseReceiptItemReq req_){
				
				InitInvocation("queryPoWarehouseReceiptItem");
				
				queryPoWarehouseReceiptItem_args args = new queryPoWarehouseReceiptItem_args();
				args.SetReq(req_);
				
				SendBase(args, queryPoWarehouseReceiptItem_argsHelper.getInstance());
			}
			
			
			private vipapis.xstore.cc.bulkbuying.api.QueryPoWarehouseReceiptItemResp recv_queryPoWarehouseReceiptItem(){
				
				queryPoWarehouseReceiptItem_result result = new queryPoWarehouseReceiptItem_result();
				ReceiveBase(result, queryPoWarehouseReceiptItem_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public vipapis.xstore.cc.bulkbuying.api.QueryPurchaseOrderResp queryPurchaseOrder(vipapis.xstore.cc.bulkbuying.api.QueryPurchaseOrderReq req_) {
				
				send_queryPurchaseOrder(req_);
				return recv_queryPurchaseOrder(); 
				
			}
			
			
			private void send_queryPurchaseOrder(vipapis.xstore.cc.bulkbuying.api.QueryPurchaseOrderReq req_){
				
				InitInvocation("queryPurchaseOrder");
				
				queryPurchaseOrder_args args = new queryPurchaseOrder_args();
				args.SetReq(req_);
				
				SendBase(args, queryPurchaseOrder_argsHelper.getInstance());
			}
			
			
			private vipapis.xstore.cc.bulkbuying.api.QueryPurchaseOrderResp recv_queryPurchaseOrder(){
				
				queryPurchaseOrder_result result = new queryPurchaseOrder_result();
				ReceiveBase(result, queryPurchaseOrder_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public vipapis.xstore.cc.bulkbuying.api.QueryPurchaseOrderItemResp queryPurchaseOrderItem(vipapis.xstore.cc.bulkbuying.api.QueryPurchaseOrderItemReq req_) {
				
				send_queryPurchaseOrderItem(req_);
				return recv_queryPurchaseOrderItem(); 
				
			}
			
			
			private void send_queryPurchaseOrderItem(vipapis.xstore.cc.bulkbuying.api.QueryPurchaseOrderItemReq req_){
				
				InitInvocation("queryPurchaseOrderItem");
				
				queryPurchaseOrderItem_args args = new queryPurchaseOrderItem_args();
				args.SetReq(req_);
				
				SendBase(args, queryPurchaseOrderItem_argsHelper.getInstance());
			}
			
			
			private vipapis.xstore.cc.bulkbuying.api.QueryPurchaseOrderItemResp recv_queryPurchaseOrderItem(){
				
				queryPurchaseOrderItem_result result = new queryPurchaseOrderItem_result();
				ReceiveBase(result, queryPurchaseOrderItem_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
			public Dictionary<string, vipapis.xstore.cc.bulkbuying.api.UpdatePoWarehouseReceiptQtyResult> updatePoWarehouseReceiptQty(vipapis.xstore.cc.bulkbuying.api.UpdatePoWarehouseReceiptQtyReq req_) {
				
				send_updatePoWarehouseReceiptQty(req_);
				return recv_updatePoWarehouseReceiptQty(); 
				
			}
			
			
			private void send_updatePoWarehouseReceiptQty(vipapis.xstore.cc.bulkbuying.api.UpdatePoWarehouseReceiptQtyReq req_){
				
				InitInvocation("updatePoWarehouseReceiptQty");
				
				updatePoWarehouseReceiptQty_args args = new updatePoWarehouseReceiptQty_args();
				args.SetReq(req_);
				
				SendBase(args, updatePoWarehouseReceiptQty_argsHelper.getInstance());
			}
			
			
			private Dictionary<string, vipapis.xstore.cc.bulkbuying.api.UpdatePoWarehouseReceiptQtyResult> recv_updatePoWarehouseReceiptQty(){
				
				updatePoWarehouseReceiptQty_result result = new updatePoWarehouseReceiptQty_result();
				ReceiveBase(result, updatePoWarehouseReceiptQty_resultHelper.getInstance());
				
				return result.GetSuccess();
				
			}
			
			
		}
		
		
	}
	
}