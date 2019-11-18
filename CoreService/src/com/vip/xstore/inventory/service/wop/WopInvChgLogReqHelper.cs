using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.xstore.inventory.service.wop{
	
	
	
	public class WopInvChgLogReqHelper : TBeanSerializer<WopInvChgLogReq>
	{
		
		public static WopInvChgLogReqHelper OBJ = new WopInvChgLogReqHelper();
		
		public static WopInvChgLogReqHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(WopInvChgLogReq structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("seqNo".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetSeqNo(value);
					}
					
					
					
					
					
					if ("companyCode".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCompanyCode(value);
					}
					
					
					
					
					
					if ("bizReceiptType".Equals(schemeField.Trim())){
						
						needSkip = false;
						int value;
						value = iprot.ReadI32(); 
						
						structs.SetBizReceiptType(value);
					}
					
					
					
					
					
					if ("bizReceiptCode".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetBizReceiptCode(value);
					}
					
					
					
					
					
					if ("warehouseStoreCode".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetWarehouseStoreCode(value);
					}
					
					
					
					
					
					if ("xlsBarcode".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetXlsBarcode(value);
					}
					
					
					
					
					
					if ("poNo".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetPoNo(value);
					}
					
					
					
					
					
					if ("stockType".Equals(schemeField.Trim())){
						
						needSkip = false;
						int value;
						value = iprot.ReadI32(); 
						
						structs.SetStockType(value);
					}
					
					
					
					
					
					if ("goodsGrade".Equals(schemeField.Trim())){
						
						needSkip = false;
						int value;
						value = iprot.ReadI32(); 
						
						structs.SetGoodsGrade(value);
					}
					
					
					
					
					
					if ("sellingStatus".Equals(schemeField.Trim())){
						
						needSkip = false;
						int value;
						value = iprot.ReadI32(); 
						
						structs.SetSellingStatus(value);
					}
					
					
					
					
					
					if ("quantity".Equals(schemeField.Trim())){
						
						needSkip = false;
						int value;
						value = iprot.ReadI32(); 
						
						structs.SetQuantity(value);
					}
					
					
					
					
					
					if ("bizTime".Equals(schemeField.Trim())){
						
						needSkip = false;
						long value;
						value = iprot.ReadI64(); 
						
						structs.SetBizTime(value);
					}
					
					
					
					
					if(needSkip){
						
						ProtocolUtil.skip(iprot);
					}
					
					iprot.ReadFieldEnd();
				}
				
				iprot.ReadStructEnd();
				Validate(structs);
			}
			else{
				
				throw new OspException();
			}
			
			
		}
		
		
		public void Write(WopInvChgLogReq structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetSeqNo() != null) {
				
				oprot.WriteFieldBegin("seqNo");
				oprot.WriteString(structs.GetSeqNo());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("seqNo can not be null!");
			}
			
			
			if(structs.GetCompanyCode() != null) {
				
				oprot.WriteFieldBegin("companyCode");
				oprot.WriteString(structs.GetCompanyCode());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("companyCode can not be null!");
			}
			
			
			if(structs.GetBizReceiptType() != null) {
				
				oprot.WriteFieldBegin("bizReceiptType");
				oprot.WriteI32((int)structs.GetBizReceiptType()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("bizReceiptType can not be null!");
			}
			
			
			if(structs.GetBizReceiptCode() != null) {
				
				oprot.WriteFieldBegin("bizReceiptCode");
				oprot.WriteString(structs.GetBizReceiptCode());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetWarehouseStoreCode() != null) {
				
				oprot.WriteFieldBegin("warehouseStoreCode");
				oprot.WriteString(structs.GetWarehouseStoreCode());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("warehouseStoreCode can not be null!");
			}
			
			
			if(structs.GetXlsBarcode() != null) {
				
				oprot.WriteFieldBegin("xlsBarcode");
				oprot.WriteString(structs.GetXlsBarcode());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("xlsBarcode can not be null!");
			}
			
			
			if(structs.GetPoNo() != null) {
				
				oprot.WriteFieldBegin("poNo");
				oprot.WriteString(structs.GetPoNo());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("poNo can not be null!");
			}
			
			
			if(structs.GetStockType() != null) {
				
				oprot.WriteFieldBegin("stockType");
				oprot.WriteI32((int)structs.GetStockType()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("stockType can not be null!");
			}
			
			
			if(structs.GetGoodsGrade() != null) {
				
				oprot.WriteFieldBegin("goodsGrade");
				oprot.WriteI32((int)structs.GetGoodsGrade()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("goodsGrade can not be null!");
			}
			
			
			if(structs.GetSellingStatus() != null) {
				
				oprot.WriteFieldBegin("sellingStatus");
				oprot.WriteI32((int)structs.GetSellingStatus()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("sellingStatus can not be null!");
			}
			
			
			if(structs.GetQuantity() != null) {
				
				oprot.WriteFieldBegin("quantity");
				oprot.WriteI32((int)structs.GetQuantity()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("quantity can not be null!");
			}
			
			
			if(structs.GetBizTime() != null) {
				
				oprot.WriteFieldBegin("bizTime");
				oprot.WriteI64((long)structs.GetBizTime()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("bizTime can not be null!");
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(WopInvChgLogReq bean){
			
			
		}
		
	}
	
}