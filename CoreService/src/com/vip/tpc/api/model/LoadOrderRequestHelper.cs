using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.tpc.api.model{
	
	
	
	public class LoadOrderRequestHelper : TBeanSerializer<LoadOrderRequest>
	{
		
		public static LoadOrderRequestHelper OBJ = new LoadOrderRequestHelper();
		
		public static LoadOrderRequestHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(LoadOrderRequest structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("loadingId".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetLoadingId(value);
					}
					
					
					
					
					
					if ("warehouseCode".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetWarehouseCode(value);
					}
					
					
					
					
					
					if ("shipperCode".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetShipperCode(value);
					}
					
					
					
					
					
					if ("carLicense".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCarLicense(value);
					}
					
					
					
					
					
					if ("loadingCount".Equals(schemeField.Trim())){
						
						needSkip = false;
						int value;
						value = iprot.ReadI32(); 
						
						structs.SetLoadingCount(value);
					}
					
					
					
					
					
					if ("operateType".Equals(schemeField.Trim())){
						
						needSkip = false;
						int value;
						value = iprot.ReadI32(); 
						
						structs.SetOperateType(value);
					}
					
					
					
					
					
					if ("pageIndex".Equals(schemeField.Trim())){
						
						needSkip = false;
						int value;
						value = iprot.ReadI32(); 
						
						structs.SetPageIndex(value);
					}
					
					
					
					
					
					if ("operateTime".Equals(schemeField.Trim())){
						
						needSkip = false;
						long value;
						value = iprot.ReadI64(); 
						
						structs.SetOperateTime(value);
					}
					
					
					
					
					
					if ("loadDetailSet".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<com.vip.tpc.api.model.LoadDetail> value;
						
						value = new List<com.vip.tpc.api.model.LoadDetail>();
						iprot.ReadSetBegin();
						while(true){
							
							try{
								
								com.vip.tpc.api.model.LoadDetail elem0;
								
								elem0 = new com.vip.tpc.api.model.LoadDetail();
								com.vip.tpc.api.model.LoadDetailHelper.getInstance().Read(elem0, iprot);
								
								value.Add(elem0);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadSetEnd();
						
						structs.SetLoadDetailSet(value);
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
		
		
		public void Write(LoadOrderRequest structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetLoadingId() != null) {
				
				oprot.WriteFieldBegin("loadingId");
				oprot.WriteString(structs.GetLoadingId());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("loadingId can not be null!");
			}
			
			
			if(structs.GetWarehouseCode() != null) {
				
				oprot.WriteFieldBegin("warehouseCode");
				oprot.WriteString(structs.GetWarehouseCode());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetShipperCode() != null) {
				
				oprot.WriteFieldBegin("shipperCode");
				oprot.WriteString(structs.GetShipperCode());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("shipperCode can not be null!");
			}
			
			
			if(structs.GetCarLicense() != null) {
				
				oprot.WriteFieldBegin("carLicense");
				oprot.WriteString(structs.GetCarLicense());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("carLicense can not be null!");
			}
			
			
			if(structs.GetLoadingCount() != null) {
				
				oprot.WriteFieldBegin("loadingCount");
				oprot.WriteI32((int)structs.GetLoadingCount()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("loadingCount can not be null!");
			}
			
			
			if(structs.GetOperateType() != null) {
				
				oprot.WriteFieldBegin("operateType");
				oprot.WriteI32((int)structs.GetOperateType()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("operateType can not be null!");
			}
			
			
			if(structs.GetPageIndex() != null) {
				
				oprot.WriteFieldBegin("pageIndex");
				oprot.WriteI32((int)structs.GetPageIndex()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("pageIndex can not be null!");
			}
			
			
			if(structs.GetOperateTime() != null) {
				
				oprot.WriteFieldBegin("operateTime");
				oprot.WriteI64((long)structs.GetOperateTime()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("operateTime can not be null!");
			}
			
			
			if(structs.GetLoadDetailSet() != null) {
				
				oprot.WriteFieldBegin("loadDetailSet");
				
				oprot.WriteSetBegin();
				foreach(com.vip.tpc.api.model.LoadDetail _item0 in structs.GetLoadDetailSet()){
					
					
					com.vip.tpc.api.model.LoadDetailHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteSetEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(LoadOrderRequest bean){
			
			
		}
		
	}
	
}