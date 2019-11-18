using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.vis.purchase.schedules.service.query{
	
	
	
	public class QueryApplySellingParamHelper : TBeanSerializer<QueryApplySellingParam>
	{
		
		public static QueryApplySellingParamHelper OBJ = new QueryApplySellingParamHelper();
		
		public static QueryApplySellingParamHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(QueryApplySellingParam structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("brandIdList".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<long?> value;
						
						value = new List<long?>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								long elem0;
								elem0 = iprot.ReadI64(); 
								
								value.Add(elem0);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetBrandIdList(value);
					}
					
					
					
					
					
					if ("shopCode".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetShopCode(value);
					}
					
					
					
					
					
					if ("sellingAction".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetSellingAction(value);
					}
					
					
					
					
					
					if ("status".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetStatus(value);
					}
					
					
					
					
					
					if ("vendorCode".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetVendorCode(value);
					}
					
					
					
					
					
					if ("dataAreaDivideList".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<int?> value;
						
						value = new List<int?>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								int elem1;
								elem1 = iprot.ReadI32(); 
								
								value.Add(elem1);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetDataAreaDivideList(value);
					}
					
					
					
					
					
					if ("vendorName".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetVendorName(value);
					}
					
					
					
					
					
					if ("sellTimeFrom".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetSellTimeFrom(value);
					}
					
					
					
					
					
					if ("sellTimeTo".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetSellTimeTo(value);
					}
					
					
					
					
					
					if ("isHt".Equals(schemeField.Trim())){
						
						needSkip = false;
						byte? value;
						value = iprot.ReadByte(); 
						
						structs.SetIsHt(value);
					}
					
					
					
					
					
					if ("sellArea".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetSellArea(value);
					}
					
					
					
					
					
					if ("specialOperationsFlag".Equals(schemeField.Trim())){
						
						needSkip = false;
						byte? value;
						value = iprot.ReadByte(); 
						
						structs.SetSpecialOperationsFlag(value);
					}
					
					
					
					
					
					if ("isNormalization".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetIsNormalization(value);
					}
					
					
					
					
					
					if ("system".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetSystem(value);
					}
					
					
					
					
					
					if ("isNeedQueryBrand".Equals(schemeField.Trim())){
						
						needSkip = false;
						bool value;
						value = iprot.ReadBool();
						
						structs.SetIsNeedQueryBrand(value);
					}
					
					
					
					
					
					if ("isNeedQueryLabel".Equals(schemeField.Trim())){
						
						needSkip = false;
						bool value;
						value = iprot.ReadBool();
						
						structs.SetIsNeedQueryLabel(value);
					}
					
					
					
					
					
					if ("page".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetPage(value);
					}
					
					
					
					
					
					if ("pageSize".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetPageSize(value);
					}
					
					
					
					
					
					if ("isNeedDepartmentIdName".Equals(schemeField.Trim())){
						
						needSkip = false;
						bool value;
						value = iprot.ReadBool();
						
						structs.SetIsNeedDepartmentIdName(value);
					}
					
					
					
					
					
					if ("shopCodeList".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<long?> value;
						
						value = new List<long?>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								long elem2;
								elem2 = iprot.ReadI64(); 
								
								value.Add(elem2);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetShopCodeList(value);
					}
					
					
					
					
					
					if ("sellingModeArr".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<byte?> value;
						
						value = new List<byte?>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								byte elem3;
								elem3 = iprot.ReadByte(); 
								
								value.Add(elem3);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetSellingModeArr(value);
					}
					
					
					
					
					
					if ("isNowSell".Equals(schemeField.Trim())){
						
						needSkip = false;
						bool value;
						value = iprot.ReadBool();
						
						structs.SetIsNowSell(value);
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
		
		
		public void Write(QueryApplySellingParam structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetBrandIdList() != null) {
				
				oprot.WriteFieldBegin("brandIdList");
				
				oprot.WriteListBegin();
				foreach(long _item0 in structs.GetBrandIdList()){
					
					oprot.WriteI64((long)_item0); 
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetShopCode() != null) {
				
				oprot.WriteFieldBegin("shopCode");
				oprot.WriteI64((long)structs.GetShopCode()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSellingAction() != null) {
				
				oprot.WriteFieldBegin("sellingAction");
				oprot.WriteString(structs.GetSellingAction());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetStatus() != null) {
				
				oprot.WriteFieldBegin("status");
				oprot.WriteString(structs.GetStatus());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetVendorCode() != null) {
				
				oprot.WriteFieldBegin("vendorCode");
				oprot.WriteI32((int)structs.GetVendorCode()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetDataAreaDivideList() != null) {
				
				oprot.WriteFieldBegin("dataAreaDivideList");
				
				oprot.WriteListBegin();
				foreach(int _item0 in structs.GetDataAreaDivideList()){
					
					oprot.WriteI32((int)_item0); 
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetVendorName() != null) {
				
				oprot.WriteFieldBegin("vendorName");
				oprot.WriteString(structs.GetVendorName());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSellTimeFrom() != null) {
				
				oprot.WriteFieldBegin("sellTimeFrom");
				oprot.WriteString(structs.GetSellTimeFrom());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSellTimeTo() != null) {
				
				oprot.WriteFieldBegin("sellTimeTo");
				oprot.WriteString(structs.GetSellTimeTo());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetIsHt() != null) {
				
				oprot.WriteFieldBegin("isHt");
				oprot.WriteByte((byte)structs.GetIsHt()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSellArea() != null) {
				
				oprot.WriteFieldBegin("sellArea");
				oprot.WriteString(structs.GetSellArea());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSpecialOperationsFlag() != null) {
				
				oprot.WriteFieldBegin("specialOperationsFlag");
				oprot.WriteByte((byte)structs.GetSpecialOperationsFlag()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetIsNormalization() != null) {
				
				oprot.WriteFieldBegin("isNormalization");
				oprot.WriteI32((int)structs.GetIsNormalization()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSystem() != null) {
				
				oprot.WriteFieldBegin("system");
				oprot.WriteString(structs.GetSystem());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetIsNeedQueryBrand() != null) {
				
				oprot.WriteFieldBegin("isNeedQueryBrand");
				oprot.WriteBool((bool)structs.GetIsNeedQueryBrand());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("isNeedQueryBrand can not be null!");
			}
			
			
			if(structs.GetIsNeedQueryLabel() != null) {
				
				oprot.WriteFieldBegin("isNeedQueryLabel");
				oprot.WriteBool((bool)structs.GetIsNeedQueryLabel());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("isNeedQueryLabel can not be null!");
			}
			
			
			if(structs.GetPage() != null) {
				
				oprot.WriteFieldBegin("page");
				oprot.WriteI32((int)structs.GetPage()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetPageSize() != null) {
				
				oprot.WriteFieldBegin("pageSize");
				oprot.WriteI32((int)structs.GetPageSize()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetIsNeedDepartmentIdName() != null) {
				
				oprot.WriteFieldBegin("isNeedDepartmentIdName");
				oprot.WriteBool((bool)structs.GetIsNeedDepartmentIdName());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("isNeedDepartmentIdName can not be null!");
			}
			
			
			if(structs.GetShopCodeList() != null) {
				
				oprot.WriteFieldBegin("shopCodeList");
				
				oprot.WriteListBegin();
				foreach(long _item0 in structs.GetShopCodeList()){
					
					oprot.WriteI64((long)_item0); 
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSellingModeArr() != null) {
				
				oprot.WriteFieldBegin("sellingModeArr");
				
				oprot.WriteListBegin();
				foreach(byte _item0 in structs.GetSellingModeArr()){
					
					oprot.WriteByte((byte)_item0); 
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetIsNowSell() != null) {
				
				oprot.WriteFieldBegin("isNowSell");
				oprot.WriteBool((bool)structs.GetIsNowSell());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("isNowSell can not be null!");
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(QueryApplySellingParam bean){
			
			
		}
		
	}
	
}